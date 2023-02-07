using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] columElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = columElements[col];
                }
            }
            int maxSquare = int.MinValue;
            string firstRow = "";
            string secondRow = "";
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > maxSquare)
                    {
                        maxSquare = sum;
                        firstRow = matrix[row, col] + " " + matrix[row, col + 1];
                        secondRow = matrix[row + 1, col] + " " + matrix[row + 1, col + 1];
                    }
                }
            }
            Console.WriteLine(firstRow);
            Console.WriteLine(secondRow);
            Console.WriteLine(maxSquare);
        }
    }
}
