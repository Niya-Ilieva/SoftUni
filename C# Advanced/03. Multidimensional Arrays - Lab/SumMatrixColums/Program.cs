using System;
using System.Linq;

namespace SumMatrixColums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[rowsAndColums[0], rowsAndColums[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columElements[col];
                }
            }
            for (int colum = 0; colum < matrix.GetLength(1); colum++)
            {
                int sum = 0;
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    sum += matrix[rows, colum];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
