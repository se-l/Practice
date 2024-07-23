using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Closure
    {
        //delegate void Action();

        public  static void ClosureExample()
        {
            int x = 0;
            // "a" represents a closure that is bound to the local variable "x" 
            Action a = delegate { Console.WriteLine(x); };

            x = 1;
            a();
        }
    }
}
