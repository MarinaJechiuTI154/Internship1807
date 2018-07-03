using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 120;
            b = 150;
            Console.WriteLine(sum(b,a));
            Console.WriteLine(prod(a, b));

            Console.ReadKey();
        }

        public static int sum(int a, int b)
        {
            return a + b;
        }
        public static int prod(int a, int b)
        {
            return a * b;
        }
    }


}
