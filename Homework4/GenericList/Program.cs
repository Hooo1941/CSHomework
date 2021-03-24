using System;

namespace GenericList
{
    class Program
    {
        static void Main()
        {
            var myList = new GenericList<int>();
            var rd = new Random();
            for (var i = 1; i<=10; i++)
            {
                myList.Add(rd.Next(0, 100));
                Console.Write($"{myList.Tail.Data} ");
            }
            Console.WriteLine();
            var sum = 0;
            var max = int.MinValue;
            var min = int.MaxValue;
            myList.ForEach(x =>
            {
                sum += x;
                max = Math.Max(max, x);
                min = Math.Min(min, x);
            });
            Console.WriteLine($"Sum is {sum}, max is {max}, min is {min}");
        }
    }
}
