namespace Practice
{ 
    /// <summary>
    /// Procedural logic disguised as object oriented programming making code easier to read though, but not to be used execessively.
    /// </summary>
    public static class MyExtensions
    {
        public static void Run()
        {
            Console.WriteLine("Extensions.Run()");

            string str = "Hello";

            Console.WriteLine(str);

            Console.WriteLine(str.AppendWorld());
            Console.WriteLine(str.CharCount());

            int two = 2;
            Console.WriteLine(two.Pow4());
        }
        public static string AppendWorld(this string str)
        {
            return str + " World";
        }

        public static int CharCount(this string str)
        {
            return str.Length;
        }

        public static int Pow4(this int a) => (int)Math.Pow(a, 4);
    }
}
