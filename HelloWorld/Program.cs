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
            Console.WriteLine("Hello World of |" + name + "|");
            Console.WriteLine($"{nameTrim} is cool when Trimmed!");
            Console.WriteLine($"When your Name is UPPER: {nameTrim.ToUpper()}{br}When Your name is lower: {nameTrim.ToLower()}");
            Console.WriteLine("The Length of your name is: " + nameTrim.Length.ToString()); // We have to convert the length into string in order to concatenate it
            Console.WriteLine(string.Format("Using \"string.Format()\" method.......> |{0}| has {1} characters", nameTrim, nameTrim.Length));
            Console.WriteLine(string.Format("Using \"string.Format()\" method to format: {0:C} Dollars is {1:P} Percentage of the World", 1288, 55));
            Console.WriteLine($"--------------------------------------------------------------------------------------------------------------{br}");

            string phrase = "This phrase was $ composed in [C# Language] with at no $ cost! :)";
            Console.WriteLine($"Phrase: |{phrase}|");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"Number of characters of the Phrase is: {phrase.Length}");
            Console.WriteLine("Left Square Braket \"[\" found at index: " + phrase.IndexOf("["));
            Console.WriteLine("First \"$\" found at index: " + phrase.IndexOf("$"));
            Console.WriteLine("Last \"$\" found at index: " + phrase.LastIndexOf("$"));
            Console.WriteLine($"Substring the Phrase, from index 16 up to 10 characters after that: |{phrase.Substring(16, 10)}|{br}");

            string newPhrase = phrase.Replace("C# Language", ".NET Framework");
            Console.WriteLine($"The new Phrase is: |{newPhrase}|");
            Console.WriteLine($"--------------------------------------------------------------------------------------------------------------{br}");

        }
    }
}
