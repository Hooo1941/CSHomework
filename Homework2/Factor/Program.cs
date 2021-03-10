using System;

namespace Factor
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please input a integer:");
            if (!int.TryParse(Console.ReadLine(), out var number))
            {
                Console.WriteLine("invalid input!");
                return;
            }

            if (number < 2)
            {
                Console.WriteLine("The number has no prime factor");
                return;
            }
            Console.Write("The prime factors of the number are:");
            for (var i = 2; i <= number / 2; i++)
            {
                if (number % i == 0) Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
