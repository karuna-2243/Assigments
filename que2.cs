using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid age. Please enter a valid number.");
                return;
            }

            Console.Write("Enter your profession: ");
            string profession = Console.ReadLine();

            Console.WriteLine($"\nHi, {name}! You are {age} years old and work as a {profession}.");
        }
    }
}
