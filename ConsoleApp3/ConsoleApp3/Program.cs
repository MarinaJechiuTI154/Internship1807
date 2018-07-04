using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5;
            b = 7;
            Console.WriteLine(exp(a, b));

            Console.ReadKey();
        }


        public static double exp(int a, int b)
        {
            return Math.Pow(a, b);
        }
    }


}
