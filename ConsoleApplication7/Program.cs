﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            Console.WriteLine(meters/(hours*3600 + minutes*60 + seconds));
            Console.WriteLine(meters/1000/(hours+minutes/60+seconds/3600));
            Console.WriteLine(meters/1609/ (hours + minutes / 60 + seconds / 3600));
        }
    }
}
