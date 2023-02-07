using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string cmd = input[0];
                if (cmd == "END")
                {
                    break;
                }
                if (cmd == "swap")
                {
                    int firstRow = int.Parse(input[1]);
                    int firstCol = int.Parse(input[2]);
                    int secondRow = int.Parse(input[3]);
                    int secondCol = int.Parse(input[4]);
                    if (firstRow < 0 || firstRow >= matrix.GetLength(0) || firstCol < 0 || firstCol >= matrix.GetLength(1) || secondRow < 0 || secondRow >= matrix.GetLength(0) || secondCol < 0 || secondCol >= matrix.GetLength(1) || input.Length < 5)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        string replaceFirstRow = matrix[firstRow, firstCol];
                        string replaceSecondRow = matrix[secondRow, secondCol];
                        matrix[firstRow, firstCol] = replaceSecondRow;
                        matrix[secondRow, secondCol] = replaceFirstRow;
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
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
