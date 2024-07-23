using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Algos
{
    internal class FuzzBuzz
    {
        /// <summary>
        /// Counting from 1 to 100, and every time a number is divisible by 3 the string "Fizz" is called, 
        /// every time a number is divisible by 5 the string "Buzz" is called and
        /// every time a number is divisible by 3 and 5 both strings together "FizzBuzz" are called instead of the number.
        /// </summary>
        public static void FizzBuzz()
        {

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sb.AppendLine($"{i} - FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    sb.AppendLine($"{i} - Fizz");
                }
                else if (i % 5 == 0)
                {
                    sb.AppendLine($"{i} - Buzz");
                }
                else
                {
                    sb.AppendLine($"{i}");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
