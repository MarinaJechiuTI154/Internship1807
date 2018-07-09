using System;
using System.Threading;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApplication1
{
    class program
    {

        static void main(string[] args)
        {


        }

        public class MathOperations
        {
            public static int fibbonaci(int n)
            {
                int result = 0;
                if (n <= 0) return 0;
                else if (n > 0 && n <= 2) return 1;

                int preoldresult = 1;
                int oldresult = 1;

                for (int i = 2; i < n; i++)
                {
                    result = preoldresult + oldresult;
                    preoldresult = oldresult;
                    oldresult = result;
                }
                return result;
            }

            public static int factorial(int n)
            {
                if (n <= 1) return 1;
                else
                    return n * factorial(n - 1);
            }

            public static double exponential(int n)
            {
                return Math.Exp(n);
            }

        }

    }
}