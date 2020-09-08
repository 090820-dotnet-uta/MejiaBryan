using System;

namespace HelloWorldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Bryan";
            Console.WriteLine("Hello Bryan!");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("Hello {0}!", name);
        }
    }
}
