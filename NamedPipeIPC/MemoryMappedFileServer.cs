using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NamedPipeIPC
{
    public class SharedEventWaitHandle : IDisposable
    {
        public EventWaitHandle waitHandle;
        public SharedEventWaitHandle(string name, bool initialState)
        {
            // need to add security to use shared event wait handle
            var users = new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null);
            var rule = new EventWaitHandleAccessRule(users, EventWaitHandleRights.Synchronize | EventWaitHandleRights.Modify,
                                      AccessControlType.Allow);
            var security = new EventWaitHandleSecurity();
            security.AddAccessRule(rule);
            bool created;
            waitHandle = new EventWaitHandle(initialState, EventResetMode.AutoReset, "Global\\" + name, out created, security);
        }

        public void Dispose()
        {
            waitHandle.Dispose();
        }
    }
    public class MemoryMappedFileConnection : IDisposable
    {
        MemoryMappedFile file;
        MemoryMappedViewAccessor accessor;
        MemoryMappedViewStream statusAccessor;
        SharedEventWaitHandle readyForRead;
        SharedEventWaitHandle finishedRead;
        SharedEventWaitHandle connected;
        SharedEventWaitHandle readyForConnection;

        const int STATUS_POSITION = 0; // byte
        const int TOTAL_LENGTH_POSITION = 1; // ulong
        const int CHUNK_LENGTH_POSITION = 9; // uint
        const int DATA_POSITION = 13; // rest of data, as byte array

        // no data availble
        byte NO_DATA = 1;
        // some of the data available (chunked)
        byte PARTIAL_DATA = 2;
        // last chunk of data (or only chunk of data)
        byte FINAL_DATA = 3;
        int bufferSize;

        // doesn't need to be shared since only the server uses it
        AutoResetEvent readyToWrite = new AutoResetEvent(false);

        bool isWriter;

        public MemoryMappedFileConnection(string id, int bufferSize, bool isWriter)
        {
            readyForRead = new SharedEventWaitHandle(id + "readyForRead", false);
            finishedRead = new SharedEventWaitHandle(id + "finishedRead", false);
            connected = new SharedEventWaitHandle(id + "connected", false);
            readyForConnection = new SharedEventWaitHandle(id + "readyForConnection", false);
            file = MemoryMappedFile.CreateNew(id, (long)bufferSize);
            accessor = file.CreateViewAccessor();
            if (isWriter)
            {
                // first byte contains status, put no data
                accessor.Write(STATUS_POSITION, (byte)1);
            }
            this.isWriter = isWriter;
            // next eight bytes contain current message total length
            // next four bytes contain current chunk length
            // rest of bytes contain message
            this.bufferSize = bufferSize - DATA_POSITION;
            readyToWrite.Set();
        }

        static void WaitOrCancel(WaitHandle waitHandle, CancellationToken cancelToken, int timeoutMillis=-1)
        {
            if (timeoutMillis >= 0)
            {
                using (CancellationTokenSource timeoutToken = new CancellationTokenSource(timeoutMillis))
                {
                    WaitHandle.WaitAny(new WaitHandle[] { waitHandle, cancelToken.WaitHandle, timeoutToken.Token.WaitHandle });
                    if (timeoutToken.IsCancellationRequested)
                    {
                        throw new TimeoutException();
                    }
                }
            }
            else
            {
                WaitHandle.WaitAny(new WaitHandle[] { waitHandle, cancelToken.WaitHandle });
            }
            if (cancelToken.IsCancellationRequested)
            {
                throw new OperationCanceledException();
            }
        }

        public void WaitForConnection(CancellationToken cancelToken, int timeoutMillis = -1)
        {
            if (!isWriter)
            {
                throw new ArgumentOutOfRangeException("Only writers can wait for connection, use Connect instead");
            }
            // we need a readyForConnection handle so only one will connect
            // (this prevents multiple connecting to this which breaks assumptions we have)
            readyForConnection.waitHandle.Set();
            WaitOrCancel(connected.waitHandle, cancelToken, timeoutMillis);
        }

        public void Connect(CancellationToken cancelToken, int timeoutMillis = -1)
        {
            if (isWriter)
            {
                throw new ArgumentOutOfRangeException("Only readers can wait for connection, use WaitForConnection instead");
            }
            WaitOrCancel(readyForConnection.waitHandle, cancelToken, timeoutMillis);
            connected.waitHandle.Set();
        }


        public bool IsPartialChunkOfData()
        {
            return accessor.ReadByte(STATUS_POSITION) == PARTIAL_DATA;
        }

        int ReadChunk(byte[] outBytes, int offset)
        {
            int length = accessor.ReadInt32(CHUNK_LENGTH_POSITION);
            accessor.ReadArray<byte>(DATA_POSITION, outBytes, offset, length);
            return length;
        }


        public byte[] ReadData(CancellationToken cancelToken, int timeoutMillis = -1)
        {
            if (isWriter)
            {
                throw new ArgumentOutOfRangeException("Only readers can ReadData");
            }
            WaitOrCancel(readyForRead.waitHandle, cancelToken, timeoutMillis);

            ulong totalLength = accessor.ReadUInt64(TOTAL_LENGTH_POSITION);

            byte[] resultBytes = new byte[totalLength];

            int offset = 0;
            while (IsPartialChunkOfData())
            {
                offset += ReadChunk(resultBytes, offset);
                // signal we are done reading
                finishedRead.waitHandle.Set();
                // wait until they have inserted the next data
                WaitOrCancel(readyForRead.waitHandle, cancelToken, timeoutMillis);
            }
            ReadChunk(resultBytes, offset);
            finishedRead.waitHandle.Set();
            return resultBytes;
        }

        void WriteDataChunk(byte[] data, int offset, int chunkLen)
        {
            accessor.WriteArray<byte>(DATA_POSITION, data, offset, chunkLen);
        }

        public void WriteData(byte[] data, int offset, int len, CancellationToken cancelToken, int timeoutMillis = -1)
        {
            if (!isWriter)
            {
                throw new ArgumentOutOfRangeException("Only writers can WriteData");
            }
            WaitOrCancel(readyToWrite, cancelToken, timeoutMillis);
            accessor.Write(TOTAL_LENGTH_POSITION, len);
            if (len > this.bufferSize)
            {
                for (int chunkStart = 0; chunkStart < len; chunkStart += this.bufferSize)
                {
                    int remaining = len - chunkStart;
                    int chunkLen = Math.Min(this.bufferSize, remaining);
                    accessor.Write(CHUNK_LENGTH_POSITION, chunkLen);
                    WriteDataChunk(data, offset + chunkStart, chunkLen);
                    bool partialChunk = chunkStart + this.bufferSize < len;
                    accessor.Write(STATUS_POSITION, partialChunk ? PARTIAL_DATA : FINAL_DATA);
                    readyForRead.waitHandle.Set();
                    WaitOrCancel(finishedRead.waitHandle, cancelToken, timeoutMillis);
                }
            }
            // we are done, a new task can write now
            readyToWrite.Set();
        }

        public void Dispose()
        {
            file.Dispose();
            accessor.Dispose();
            readyToWrite.Dispose();
            readyForRead.Dispose();
            finishedRead.Dispose();
            connected.Dispose();
            readyForConnection.Dispose();
        }
    }
}
