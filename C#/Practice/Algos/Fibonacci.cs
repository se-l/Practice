using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Algos
{
    /// <summary>
    /// Write generator for first n elements of Fibonacci series and print
    /// </summary>
    internal class Fibonacci
    {
        public static void PrintFibonacciSequence(int n)
        {
            List<int> sequence = new List<int>();
            for (int i = 0; i < n; i++)
            {
                sequence.Add(GetNthFibonacci(i));
            }
            Console.WriteLine(string.Join(", ", sequence));
        }

        static Dictionary<int, int> g_Results = new Dictionary<int, int>();

        public static int GetNthFibonacci(int n)
        {
            if (g_Results.ContainsKey(n))
            {
                Console.WriteLine($"Returning from cache for {n}");
                return g_Results[n];
            }
            if (n < 2)
            {
                return n;
            }
            g_Results[n] = GetNthFibonacci(n - 2) + GetNthFibonacci(n - 1);
            return g_Results[n];
        }

        public static IEnumerable<int> GetFibonacciNumbers(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return GetNthFibonacci(i);
            }
        }

        /// <summary>
        /// Using closures
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>

        // Need to declare the delegate because the lambda expression is recursive
        delegate int FibonacciCalculator(int n);
        public static int CalcFibonacciClosures(int n)
        {
            int[] results = new int[n + 1];

            //  The C# compiler requires "calculator" to be definitely assigned before it can be called inside the anonymous method body. Setting "calculator" to null 
            FibonacciCalculator calculator = null;
            // Declare a custom delegate type ("FibonacciCalculator") to make this work
            calculator = delegate (int x)
            {
                if (x < 2)
                    return x;
                else
                {
                    if (results[x] == 0)
                        results[x] = calculator(x - 1) + calculator(x - 2);

                    return results[x];
                }
            };

            return calculator(n);
        }
    }
}
