using System;

namespace appTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello World of " + name + "!");
            Console.WriteLine($"{name} is cool !");
        }
    }
}
