
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace method_examples
{
    class number
    {
        static public int numberInt1;
        static public double numberDouble1;
        public int numberInt2;
        public double numberDouble2;
    }
    class Program
    {
        static void Main()
        {
            number.numberInt1 = 10;
            number.numberInt2 = 20;
            number.numberDouble1 = 100.500;
            number.numberDouble2 = 200.500;

            Console.WriteLine($"numberInt1 = {number.numberInt1}");
            Console.WriteLine($"numberInt2 = {number.numberInt2}");
            Console.WriteLine($"numberDouble1 = {number.numberDouble1}");
            Console.WriteLine($"numberDouble2 = {number.numberDouble2}");

        }
    }
}