using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Msc CS!");
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            string abc = "Hello msc";
            Console.WriteLine($"Hello, {name}! {abc}!!");
        }
    }
}
