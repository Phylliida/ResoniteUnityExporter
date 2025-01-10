using System;
using System.Collections.Concurrent;
using System.Threading;

namespace MemoryMappedFileIPC
{
    public class ConcurrentQueueWithNotification<T> { 
        private ConcurrentQueue<T> queue = new ConcurrentQueue<T>();
        private AutoResetEvent signal = new AutoResetEvent(false);

        public void Enqueue(T item)
        {
            queue.Enqueue(item);
            signal.Set(); // Signal that queue has an item
        }

        /// <summary>
        /// Timeoutmillis < 0 means wait until stopToken is triggered or item is recieved
        /// </summary>
        /// <param name="item"></param>
        /// <param name="timeoutMillis"></param>
        /// <param name="stopToken"></param>
        /// <returns></returns>
        /// <exception cref="OperationCanceledException"></exception>
        public bool TryDequeue(out T item, int timeoutMillis, CancellationToken stopToken)
        {
            while (!stopToken.IsCancellationRequested)
            {
                if (queue.TryDequeue(out item))
                {
                    return true;
                }

                int tokenIndex = WaitHandle.WaitAny(new[] { stopToken.WaitHandle, signal }, timeoutMillis);
                
                // stopped
                if (tokenIndex == 0)
                {
                    throw new OperationCanceledException();
                }
                // timed out
                else if(tokenIndex == WaitHandle.WaitTimeout) {
                    item = default;
                    return false;
                }
                // recieved an entry in the queue, return it (above)
                else if(tokenIndex == 1) {

                }
            }

            throw new OperationCanceledException();
        }

        public void Dispose()
        {
            signal.Dispose();
        }
    }

}