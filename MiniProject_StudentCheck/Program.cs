namespace MiniProject_StudentCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name and age (separated by a space): ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            string name = parts[0];
            int age = int.Parse(parts[1]);

            Console.WriteLine($"age: {age}, name: {name}");

            if (name.ToLower() == "bob" || name.ToLower() == "sue")
            {
                Console.WriteLine($"Hello, Professor {name}!");
            }
            else
            {
                Console.WriteLine($"Hello, {name}!");
            }

            if (age < 21)
            {
                Console.WriteLine($"You need to wait {21 - age} years before starting this class.");
            }
            else
            {
                Console.WriteLine("Welcome to this class.");
            }
        }
    }
}
