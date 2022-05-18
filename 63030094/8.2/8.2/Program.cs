using System;

namespace _8._2
{
    class Program
    {
        string name = "Hello";
        Console.WriteLine(String.Format("{0} there. I said {0}! {0}???", name));
    Console.WriteLine($"{2:d} {0:d} {1:d}", 1, 2, 3);
    Console.WriteLine($"Hello " + $"World");
    Console.WriteLine($"Here comes a slash \\");
    Console.WriteLine($"|{999, 10}|");
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
    for (i = 1; i< 10; i++)
        Console.WriteLine($"{i}\t{i*i}\t{i*i*i}");
    Console.WriteLine($"{1234.56789:#.###}.");

            }
        }
    }
}
    }
}
