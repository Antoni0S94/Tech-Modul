using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sub = Console.ReadLine();
            string substring = sub.Substring(2);
            var num = Convert.ToInt32(substring, 16);
            Console.WriteLine(num);
        }
    }
}
