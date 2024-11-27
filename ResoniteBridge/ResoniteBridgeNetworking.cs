using ResoniteDataWrapper;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ResoniteBridge
{
    public class ResoniteBridgeServer : IDisposable
    {
        public const string NAMED_SOCKET_KEY = "ResoniteCustomBridge";

        Thread monitoringThread;

        public volatile bool running = true;

        public ConcurrentQueue<ResoniteBridgeMessage> messages = new ConcurrentQueue<ResoniteBridgeMessage>();
        public ResoniteBridgeServer ()
        {
            // network monitoring thread
            monitoringThread = new Thread(() =>
            {
                while (running)
                {
                    using (NamedPipeServerStream pipeServer =
                        new NamedPipeServerStream(NAMED_SOCKET_KEY, PipeDirection.InOut))
                    {

                        Console.WriteLine("Waiting for connection to unity");

                        pipeServer.WaitForConnection();

                        Console.WriteLine("Connected to unity");
                        try
                        {
                            // Read the request from the client. Once the client has
                            // written to the pipe its security token will be available.

                            StreamString ss = new StreamString(pipeServer);

                            // Verify our identity to the connected client using a
                            // string that the client anticipates.
                            ss.WriteString("Hello!");
                            while (true)
                            {
                                string filename = ss.ReadString();
                                Console.WriteLine("Recieved string: '" + ss.ReadString() + "'");
                            }
                        }
                        // Catch the IOException that is raised if the pipe is broken
                        // or disconnected.
                        catch (IOException e)
                        {
                            Console.WriteLine("Disconnected from unity with error");
                            Console.WriteLine("ERROR: {0}", e.Message);
                        }
                    }
                }
            });

            monitoringThread.Start();
        }

        public void Dispose()
        {
            running = false;
            monitoringThread.Join();
        }
    }

    public class StreamString
    {
        private Stream ioStream;
        private UnicodeEncoding streamEncoding;

        public StreamString(Stream ioStream)
        {
            this.ioStream = ioStream;
            streamEncoding = new UnicodeEncoding();
        }

        public string ReadString()
        {
            int len = 0;

            len = ioStream.ReadByte() * 256;
            len += ioStream.ReadByte();
            byte[] inBuffer = new byte[len];
            ioStream.Read(inBuffer, 0, len);

            return streamEncoding.GetString(inBuffer);
        }

        public int WriteString(string outString)
        {
            byte[] outBuffer = streamEncoding.GetBytes(outString);
            int len = outBuffer.Length;
            if (len > UInt16.MaxValue)
            {
                len = (int)UInt16.MaxValue;
            }
            ioStream.WriteByte((byte)(len / 256));
            ioStream.WriteByte((byte)(len & 255));
            ioStream.Write(outBuffer, 0, len);
            ioStream.Flush();

            return outBuffer.Length + 2;
        }
    }
}
