using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please input M and N:");
            var line = Console.ReadLine()?.Trim().Split(' ');
            if (line == null || (!int.TryParse(line[0], out var m) || !int.TryParse(line[1], out var n)))
            {
                Console.WriteLine("invalid input!");
                return;
            }

            var matrix = new int[m][];
            Console.WriteLine("input a M*N matrix:");
            for (var i = 0; i < m; i++)
            {
                line = Console.ReadLine()?.Trim().Split(' ');
                matrix[i] = Array.ConvertAll(line ?? Array.Empty<string>(), int.Parse);
                if (matrix[i].Length == n) continue;
                Console.WriteLine("invalid input!");
                return;
            }

            Console.WriteLine(CheckMatrix(m, n, matrix) ? "It's a toeplitz matrix" : "It's not a toeplitz matrix");
        }

        private static bool CheckMatrix(int m, int n, IReadOnlyList<int[]> matrix)
        {
            for (var i = 0; i < n; i++)
                for (var k = 0; k + i < m && k < n; k++)
                    if (matrix[i + k][k] != matrix[i][0])
                        return false;
            for (var i = 0; i < m; i++)
                for (var k = 0; k + i < n && k < m; i++)
                    if (matrix[k][i + k] != matrix[0][i])
                        return false;
            return true;
        }
    }
}
