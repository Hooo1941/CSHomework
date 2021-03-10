using System;
using System.Linq;

namespace Statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input one line of integer, separate by space.");
            try
            {
                var line = Console.ReadLine()?.Trim().Split(' ');
                var numbers = Array.ConvertAll(line ?? Array.Empty<string>(), int.Parse);
                var max = numbers.Max();
                var min = numbers.Min();
                var sum = numbers.Sum();
                var avg = numbers.Average();
                Console.WriteLine(
                    $"max of numbers is {max}\nmin of numbers is {min}\naverage of numbers is {avg}\nsum of numbers is {sum}\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
        }
    }
}
