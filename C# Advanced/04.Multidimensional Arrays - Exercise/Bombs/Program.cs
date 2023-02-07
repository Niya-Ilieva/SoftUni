using System;
using System.Linq;
using System.Collections.Generic;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            string[] coordinatesOfBombs = Console.ReadLine().Split();
            for (int i = 0; i < coordinatesOfBombs.Length; i++)
            {
                string[] splitedCoordinates = coordinatesOfBombs[i].Split(",");
                int row = int.Parse(splitedCoordinates[0]);
                int col = int.Parse(splitedCoordinates[1]);

                int numberToBomb = matrix[row, col];
                if (numberToBomb == 0 || numberToBomb < 0)
                {
                    continue;
                }
                else
                {
                    matrix[row, col] = 0;
                    if (row - 1 >= 0)
                    {
                        if (matrix[row - 1, col] > 0)
                        {
                            matrix[row - 1, col] -= numberToBomb;
                        }

                        if (col - 1 >= 0 && matrix[row - 1, col - 1] > 0)
                        {
                            matrix[row - 1, col - 1] -= numberToBomb;
                        }
                        if (col + 1 < matrix.GetLength(1) && matrix[row - 1, col + 1] > 0)
                        {
                            matrix[row - 1, col + 1] -= numberToBomb;
                        }
                    }
                    if (row + 1 < matrix.GetLength(0))
                    {
                        if (matrix[row + 1, col] > 0)
                        {
                            matrix[row + 1, col] -= numberToBomb;
                        }

                        if (col - 1 >= 0 && matrix[row + 1, col - 1] > 0)
                        {
                            matrix[row + 1, col - 1] -= numberToBomb;
                        }
                        if (col + 1 < matrix.GetLength(1) && matrix[row + 1, col + 1] > 0)
                        {
                            matrix[row + 1, col + 1] -= numberToBomb;
                        }

                    }
                    if (col - 1 >= 0 && matrix[row, col - 1] > 0)
                    {
                        matrix[row, col - 1] -= numberToBomb;
                    }
                    if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] > 0)
                    {
                        matrix[row, col + 1] -= numberToBomb;
                    }
                }
            }
            int sum = 0;
            int activeCellsCounter = 0;
            foreach (var number in matrix)
            {
                if (number > 0)
                {
                    sum += number;
                    activeCellsCounter++;
                }
            }
            Console.WriteLine($"Alive cells: {activeCellsCounter}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
