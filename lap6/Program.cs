using System;

namespace lap6
{
    internal class Program
    {

        public delegate void Increment(ref int X);
        public static void Add2 (ref int x)
        {
            x += 2;
        }
        public static void Add3 (ref int x)
        {
            x += 3;
        }
        
        public static void Main(string[] args)
        {
            Increment increment = Add2;
            increment += Add3;
            increment += Add2;
            var x = 5;
            increment(ref x);
            Console.WriteLine(x);
        }
    }
}