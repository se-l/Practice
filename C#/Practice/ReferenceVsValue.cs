using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ReferenceVsValue
    {
        public static void Run()
        {
            StructCheck();
        }
        public struct MyStruct
        {
            public int MyInt { get; set; }
            public string MyStr { get; set; }
            public void MyMethod()
            {
                Console.WriteLine("MyStruct.MyMethod()");
            }
        }

        public static void LogVarAddress(object obj)
        {
            Console.WriteLine($"LogVarAddress: Object address: {obj.GetHashCode()}");
        }

        public static void StructCheck()
        {
            MyStruct a = new() { MyInt = 4, MyStr = "sdf" };
            a.MyMethod();
            Console.WriteLine($"Struct address a: {a.GetHashCode()}");
            LogVarAddress(a);
            MyStruct b;
            b = a;
            Console.WriteLine($"Struct b address: {b.GetHashCode()}");

            a.MyInt = 5;
            Console.WriteLine($"Struct a.MyInt: {a.MyInt}");
            Console.WriteLine($"Struct address a: {a.GetHashCode()}");
            Console.WriteLine($"Struct b address: {b.GetHashCode()}");
            Console.WriteLine($"Struct b.MyInt: {b.MyInt}");
            Console.WriteLine($"Struct address a: {a.GetHashCode()}");
            Console.WriteLine($"Struct b address: {b.GetHashCode()}");
        }
    }
}
