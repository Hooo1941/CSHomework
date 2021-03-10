using System;

namespace Prime
{
    class Program
    {
        static void Main()
        {
            bool[] table = new bool[110]; //素数表
            Console.WriteLine("The prime numbers between 2~100 are:");
            for (var i = 2; i <= 100; i++)
            {
                if (table[i] == false)
                {
                    Console.Write($"{i} ");
                    for (var j = i + i; j <= 100; j += i)
                    {
                        table[j] = true;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
