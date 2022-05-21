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
            Console.WriteLine("{0} and {1}", 3, 5);
            Console.WriteLine("{0} and {1}", 3.0, 5.0);
            Console.WriteLine("{0} and {1}", 3.0d, 5.0d);
            Console.WriteLine("{0:F1} and {1:F1}", 3.0, 5.0);
            Console.WriteLine("{0:F2} and {1:F2}", 3.0d, 5.0d);
        }
    }
}
