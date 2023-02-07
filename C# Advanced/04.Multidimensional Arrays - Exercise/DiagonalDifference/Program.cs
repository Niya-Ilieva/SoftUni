using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int sumFromLeft = 0;
            int leftSumCounter = size;
            int sumFromRight = 0;
            int rightSumCounter = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colNumbers[col];
                }
                sumFromLeft += matrix[row, colNumbers.Length - leftSumCounter];
                sumFromRight += matrix[row, colNumbers.Length - rightSumCounter];
                rightSumCounter++;
                leftSumCounter--;
            }
            int result = Math.Abs(sumFromLeft - sumFromRight);
            Console.WriteLine(result);

        }
    }
}
