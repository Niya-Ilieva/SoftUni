using System;
using System.Linq;

namespace _2x2SquareInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int matchCounter = 0;
            char[,] matrix = new char[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            if (size[0] >= 2 && size[1] >= 2)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        char currentChar = matrix[row, col];
                        if (currentChar == matrix[row, col + 1] && currentChar == matrix[row + 1, col] && currentChar == matrix[row + 1, col + 1])
                        {
                            matchCounter++;
                        }
                    }
                }
            }
            Console.WriteLine(matchCounter);
        }
    }
}
