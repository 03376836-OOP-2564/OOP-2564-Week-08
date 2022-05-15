using System;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace Project8._2
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

                Console.WriteLine($"{3} and {1}");
                Console.WriteLine($"{3} and {1}");
                Console.WriteLine($"{3.0d} and {1.0001d}");
                Console.WriteLine($"{3:F2} and {1000.123:F1}");
                Console.WriteLine($"{3.123456:F2} and {5.123000:F4}");

                Console.WriteLine($"         1111111111222222");
                Console.WriteLine($"1234567890123456789012345");
                Console.WriteLine($"{1,0}");
                Console.WriteLine($"{1,1}");
                Console.WriteLine($"{1,2}");
                Console.WriteLine($"{1,3}");
                Console.WriteLine($"{1,4}");
                Console.WriteLine($"{1,5}");
                Console.WriteLine($"{1,10}");
                Console.WriteLine($"{1,15}");
                Console.WriteLine($"{1,20}");
                Console.WriteLine($"{1,22}");
                Console.WriteLine($"{1,25}");

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

                const double i = 123.456789;
                Console.WriteLine($"{i,10:F1}");
                Console.WriteLine($"{i,10:F2}");
                Console.WriteLine($"{i,10:F3}");
                Console.WriteLine($"{i,10:F4}");
                Console.WriteLine($"{i,10:F5}");

                string name = "Hello";
                Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
                Console.WriteLine($"{2:d} {0:d} {1:d}", 1, 2, 3);
                Console.WriteLine($"Hello " + $"World");
                Console.WriteLine($"Here comes a slash \\");
                Console.WriteLine($"|{999,10}|");
                Console.WriteLine($"|{000,-10}|");
                Console.WriteLine($"The value: {500}.");
                Console.WriteLine($"The value: {500:C}.");
                Console.WriteLine($"{12.3456789,-10:F4}");
                Console.WriteLine($"{12.3456789,-10:C}");
                Console.WriteLine($"{12.3456789,-10:E3}");
                Console.WriteLine($"{65535,-10:x}");
                Console.WriteLine($"{65535,-10:X}");
                int i;
                Console.WriteLine("Value\tSquared\tCubed");
                for (i = 1; i < 10; i++)
                    Console.WriteLine($"{i}\t{i * i}\t{i * i * i}");
                Console.WriteLine($"{1234.56789:#.###}.");
            }
        }
    }
}
    }
}
