using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            if (Math.Abs(first - second) < eps) { Console.WriteLine("True"); }
            else { Console.WriteLine("False"); }
        }
    }
}
