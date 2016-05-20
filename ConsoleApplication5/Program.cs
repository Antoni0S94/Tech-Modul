using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            string Id = Console.ReadLine();
            string uniqueNum = Console.ReadLine();

            Console.WriteLine("First name: " + name);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Personal ID: " + Id);
            Console.WriteLine("Unique Employee number: " + uniqueNum);
        }
    }
}
