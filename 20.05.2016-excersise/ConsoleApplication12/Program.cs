using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());
            List<int> isPrime = new List<int>();
            for (int i = a; i <= b; i++)
            {
                checkIsPrime(isPrime, i);
            }

            Console.WriteLine(string.Join(", ",isPrime));
        }

        private static void checkIsPrime(List<int> isPrime, int i)
        {
            bool isPrimer = true;
            if (i == 0 || i == 1)
            {
                isPrimer = false;
            }
            else
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrimer = false;

                    }

                }

            }
            if (isPrimer) { isPrime.Add(i); }
        }
    }
}
