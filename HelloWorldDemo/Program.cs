using System;

namespace HelloWorldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // String name = "Bryan";
            // Console.WriteLine("Hello Bryan!");
            // Console.WriteLine("What is your name?");
            // name = Console.ReadLine();
            // Console.WriteLine($"Hello {name}!");
            // Console.WriteLine("Hello {0}!", name);

            Player p1 = new Player();
            // Func<> print = Console.WriteLine;
            Console.WriteLine(p1);
            // if (p1 == null){
            //     Console.WriteLine("p1 is null");
            // }
            // p1.Name = "Tom";
            // Console.WriteLine(p1.Name);
        }
    }
}

public class Player{
        public string Name{
            get; set;
        }
    }