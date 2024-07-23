using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class AsyncConcurrency
    {
        public static void RunAsyncExamples()
        {
            Console.WriteLine($"{DateTime.Now} Starting async task. Not awaited");
            Task.Run(() => Square(5)).ContinueWith((task) =>
            {
                Console.WriteLine($"{DateTime.Now} task.Result: {task.Result}. Took 1 second.");
            });

            Console.WriteLine($"{DateTime.Now} Code beyond first unawaited aync task. Starting the second async task essentially in parallel.");

            Task.Run(() => Square(10).ContinueWith((task) =>
            {
                Console.WriteLine($"{DateTime.Now} task.Result: {task.Result} finishing same time as first tasks.");
            })).Wait(TimeSpan.FromSeconds(5));
            Console.WriteLine($"{DateTime.Now} Code beyond second async task that was waited for till completion. Hence same time as result.");
        }

        public static async Task<int> Square(int num)
        {
            await Task.Delay(1000);
            return num * num;
        }
    }
}
