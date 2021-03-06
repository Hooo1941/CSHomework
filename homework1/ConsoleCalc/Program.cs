using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input one number:");
            var line = Console.ReadLine();
            if (!double.TryParse(line,out var a))
            {
                Console.WriteLine("invalid input!");
                return;
            }

            Console.WriteLine("Input another number:");
            line = Console.ReadLine();
            if (!double.TryParse(line, out var b))
            {
                Console.WriteLine("invalid input!");
                return;
            }

            Console.WriteLine("Input an operator");
            line = Console.ReadLine();
            switch (line)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a+b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Could not divide by zero!");
                        return;
                    }
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                default:
                    Console.WriteLine("operator must be +,-,* or /");
                    break;
            }
        }
    }
}
