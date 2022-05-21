using System;

namespace project__8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123456789;
            Console.WriteLine("Regular string format");
            Console.WriteLine("         {0,20}", i);
            Console.WriteLine("String interpreter");
            Console.WriteLine($"None ==> {i,20}");
            Console.WriteLine($"   E ==> {i,20:E}");
            Console.WriteLine($"   F ==> {i,20:F}");
            Console.WriteLine($"   G ==> {i,20:G}");
            Console.WriteLine($"   N ==> {i,20:N}");
            Console.WriteLine($"   P ==> {i,20:P}");
            Console.WriteLine($"   X ==> {i,20:X}");
        }
    }
}