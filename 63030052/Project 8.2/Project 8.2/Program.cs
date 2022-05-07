using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double i = 123.456789;
            Console.WriteLine($"{i,10:F1}");
            Console.WriteLine($"{i,10:F2}");
            Console.WriteLine($"{i,10:F3}");
            Console.WriteLine($"{i,10:F4}");
            Console.WriteLine($"{i,10:F5}");
        }
    }
}
