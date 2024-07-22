﻿using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace Practice
{
    /// <summary>
    /// read again 
    /// What are generics in C# .NET?
    /// https://www.simplilearn.com/tutorials/c-sharp-tutorial/c-sharp-interview-questions
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"MyClass int: {new MyClass(2).MyInt}");
            Console.WriteLine($"MyyRecord: {new MyRecord()}");
            var cls = new MyRecord() { A = "as", MyInt = 3 };
            Console.WriteLine($"MyyRecord: {cls.MyInt}");

            // serialize cls to json
            var json = JsonSerializer.Serialize(cls);
            Console.WriteLine($"MyyRecord JSON: {json}");

            var arr = new[] { 1, 2, 3 };
            arr = arr.Append(4).ToArray();
            Console.WriteLine($"Array: {string.Join(",", arr)}");

            var str = new StringBuilder();
            str.Append("Hello");
            Console.WriteLine($"StringBuilder: {str.ToString()} @ {str.GetHashCode()}");
            str.Append(" World");
            Console.WriteLine($"StringBuilder: {str.ToString()} @ {str.GetHashCode()}");

            var str2 = "Hello";
            Console.WriteLine($"String: {str2.ToString()} @ {str2.GetHashCode()}");
            str2 += " World";
            Console.WriteLine($"String: {str2.ToString()} @ {str2.GetHashCode()}");

            PracticeDelegates();

            StructCheck();

            Console.WriteLine(string.Join(",", Enumerable.Repeat(4, 4).ToArray()));

            Console.WriteLine("sdfsadf" is string);
            Console.WriteLine("sdfsadf" is int);

            Console.WriteLine(Singleton.Instance);
            Console.WriteLine(Singleton.Instance);

            Tuple<int, string> tuple = new(1, "sdf");

            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            // Create a Regex object using the email pattern
            Regex emailRegex = new Regex(emailPattern);
            // Test the regular expression against some email addresses
            Console.WriteLine(emailRegex.IsMatch("example@example.com")); // Output: true

            int[] arr2 = new int[3];
            arr2[0] = 1;
            Console.WriteLine($"Array: {string.Join(",", arr2)}");
        }

        delegate int MyDelegate(int a, int b);

        public static void PracticeDelegates()
        {            
            MyDelegate myDelegate = (a, b) => a + b;
            Console.WriteLine($"Delegate: {myDelegate(1, 2)}");
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
            MyStruct a = new () { MyInt=4, MyStr="sdf"};
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

        // Access Modifiers:
        // public
        // private
        // protected
        // internal
        // protected internal - protected OR internal
        // private protected - private OR protected
        // sealed

        // abstract
        // virtual
        // static
    }

    public class MyClass
    {
        private readonly int _myInt;
        public int MyInt { get => _myInt; }

        public MyClass(int myInt)
        {
            _myInt = myInt;
        }
    }

    public class MyRecord
    {
        public int MyInt { get; set; }
        public string A { get; set; }
    }
}
