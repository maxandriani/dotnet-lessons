using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = "Hello";
            var name = "World";

            if (args.Length > 0)
            {
                name = string.Join(" ", args);
            }

            Console.WriteLine($"{phrase} {name}!");
            Console.ReadKey();
        }
    }
}
