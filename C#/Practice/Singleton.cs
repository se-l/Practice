using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new();

        static Singleton()
        {
            Console.WriteLine("Singleton static constructor.");
        }

        private Singleton()
        {
            Console.WriteLine("Singleton constructor.");
        }

        public static Singleton Instance
        {
            get
            {
                Console.WriteLine("Singleton Instance.");
                return instance;
            }
        }
    }
}
