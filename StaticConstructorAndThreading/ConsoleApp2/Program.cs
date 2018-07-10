using System;
using System.Threading;


namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            int fibb = 0;
            double exp = 0, fact = 0; ;
            Thread thread = new System.Threading.Thread(() => {
                fibb = MathOperations.Fibbonaci(20);
            });
            Thread thread1 = new System.Threading.Thread(() => {
                fact = MathOperations.Factorial(20);
            });
            Thread thread2 = new System.Threading.Thread(() => {
                exp = MathOperations.Exponential(20);
            });

            thread.Start();
            thread1.Start();
            thread2.Start();
            thread.Join();
            thread1.Join();
            thread2.Join();

            Console.WriteLine("Al 20 nr fibbonacii: " + fibb);
            Console.WriteLine("Factorial de 20 : " + fact);
            Console.WriteLine("Exponential de 20: " + exp);
            Console.ReadKey();
        }

    }
    public class MathOperations
    {
        public static int Fibbonaci(int n)
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

        public static double Factorial(int n)
        {
            if (n <= 1) return 1;
            else
                return n * Factorial(n - 1);
        }

        public static double Exponential(int n)
        {
            return Math.Exp(n);
        }

    }
}