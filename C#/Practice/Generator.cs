using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    /// <summary>
    /// Fibonacci
    /// </summary>
    internal class Generator
    {
        public IEnumerable<int> GetNumbers()

        {
            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }
        }
    }
}
