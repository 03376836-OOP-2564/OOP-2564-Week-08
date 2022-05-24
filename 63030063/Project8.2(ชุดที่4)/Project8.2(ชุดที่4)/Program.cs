using System;

namespace project__8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123456789;
            Console.WriteLine("Regular string format");
            Console.WriteLine("{0}", i);
            Console.WriteLine("String interpreter");
            Console.WriteLine($"None ==> {i}");
            Console.WriteLine($"   E ==> {i:E}");
            Console.WriteLine($"   F ==> {i:F}");
            Console.WriteLine($"   G ==> {i:G}");
            Console.WriteLine($"   N ==> {i:N}");
            Console.WriteLine($"   P ==> {i:P}");
            Console.WriteLine($"   X ==> {i:X}");
        }
    }
}