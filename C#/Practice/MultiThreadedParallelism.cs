using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    /// <summary>
    /// parallel.foreach
    /// thread.pool
    /// lock
    /// Concurrent Datastructures
    /// Object pooling
    /// </summary>
    public class MultiThreadedParallelism
    {
        public static void RunThreadPoolExample()
        {
            for (int k=0; k < 3; k++)
            {
                Console.WriteLine($"Thread {k} queued");
                Action<object> actionk = (object obj) => DoWork($"Pool Thread {k}");
                ThreadPool.QueueUserWorkItem(new WaitCallback(actionk));
            }
        }

        public static void RunParralelExample()
        {
            Parallel.For(0, 3, i => DoWork($"Parallel Thread {i}"));
        }

            public static void DoWork(string name)
        {
            Console.WriteLine($"{name} started");
            Thread thread = Thread.CurrentThread;

            for (int i=0; i< 5; i++) 
            {
                Thread.Sleep(i * 500);

                string message = $"{DateTime.Now} Thread {name}, Second {i}, Background: {thread.IsBackground}, " +
                    $"Thread Pool: {thread.IsThreadPoolThread}, Thread ID: {thread.ManagedThreadId}";
                Console.WriteLine(message);
            }
        }

        public static void StartCPUBoundTask()
        {
            Action action = () => DoWork("CPU Bound Task");
            Task.Factory.StartNew(action);
        }
    }
}
