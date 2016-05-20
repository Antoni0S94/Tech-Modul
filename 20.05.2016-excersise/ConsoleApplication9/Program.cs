using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(n,16).ToUpper());
            Console.WriteLine(Convert.ToString(n,2).ToUpper());
        }
    }
}
