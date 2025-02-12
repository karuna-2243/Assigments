using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[]args )
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Prompt the user to choose the operation
            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();

            // Perform the operation and store the result
            double result = 0; // Initialize result at the point of usage, in case we need it for division by zero check

            // Perform the operation based on the user's choice
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    // Handle division by zero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return; // Exit the program if division by zero
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation! Please choose +, -, *, or /.");
                    return; // Exit the program if an invalid operation is entered
            }

            // Display the result
            Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");


        }
    }
}

            
        
    
    


      
    


