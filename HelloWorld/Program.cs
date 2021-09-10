using System;

namespace appTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            // String class (The actual .NET class)
            // string (is an C# alias of the String .NET class) - C# way of defining a string class (it is an alias) 
            String name = Console.ReadLine();
            string br = Environment.NewLine; // NewLine used for cross-platform
            string nameTrim = name.Trim();

            Console.WriteLine();
            Console.WriteLine("Hello World of |" + name + "| !");
            Console.WriteLine($"{nameTrim} is cool when Trimmed!");
            Console.WriteLine($"When your Name is UPPER: {nameTrim.ToUpper()}{br}When Your name is lower: {nameTrim.ToLower()}");
            Console.WriteLine("The Length of your name is: " + nameTrim.Length.ToString()); // We have to convert the length into string in order to concatenate it
            Console.WriteLine(string.Format("Using \"string.Format()\" method.......> |{0}| has {1} characters", nameTrim, nameTrim.Length));
            Console.WriteLine(string.Format("Using \"string.Format()\" method to format: {0:C} Dollars is {1:P} Percentage of the World", 1288, 55));


        }
    }
}
