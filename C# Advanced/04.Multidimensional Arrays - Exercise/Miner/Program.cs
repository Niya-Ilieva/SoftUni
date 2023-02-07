using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            int startRow = 0;
            int startCol = 0;
            int coalCounter = 0;
            int endGame = 0;

            var queue = new Queue<string>(commands);
            char[,] matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (colElements[col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                    if (colElements[col] == 'c')
                    {
                        coalCounter++;
                    }
                    matrix[row, col] = colElements[col];
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                string currnetCoomand = queue.Dequeue();
               

                if (currnetCoomand == "left")
                {
                    if (startCol - 1 >= 0)
                    {
                        startCol -= 1;
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({ startRow}, { startCol})");
                            endGame++;
                            break;
                        }
                        if (matrix[startRow, startCol] == 'c')
                        {
                            coalCounter--;
                            matrix[startRow, startCol] = '*';
                            if (coalCounter == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({startRow}, { startCol})");
                                break;
                            }
                        }
                    }
                }
                if (currnetCoomand == "right")
                {
                    if (startCol + 1 < matrix.GetLength(1))
                    {
                        startCol += 1;
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({ startRow}, { startCol})");
                            endGame++;
                            break;
                        }
                        if (matrix[startRow, startCol] == 'c')
                        {
                            coalCounter--;
                            matrix[startRow, startCol] = '*';
                            if (coalCounter == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({startRow}, { startCol})");
                                break;
                            }
                        }
                        
                    }
                }
                if (currnetCoomand == "up")
                {
                    if (startRow - 1 >= 0)
                    {
                        startRow -= 1;
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({ startRow }, { startCol})");
                            endGame++;
                            break;
                        }
                        else if (matrix[startRow, startCol] == 'c')
                        {
                            coalCounter--;
                            matrix[startRow, startCol] = '*';
                            if (coalCounter == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({startRow}, { startCol})");
                                break;
                            }
                        }
                        
                    }
                }
                if (currnetCoomand == "down")
                {
                    if (startRow + 1 < matrix.GetLength(0))
                    {
                        startRow += 1;
                        if (matrix[startRow, startCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({ startRow }, { startCol})");
                            endGame++;
                            break;
                        }
                        else if (matrix[startRow, startCol] == 'c')
                        {
                            coalCounter--;
                            matrix[startRow, startCol] = '*';
                            if (coalCounter == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({startRow}, { startCol})");
                                break;
                            }
                        }
                    }
                }
            }
            if (coalCounter > 0 && endGame == 0)
            {
                Console.WriteLine($"{coalCounter} coals left. ({startRow}, {startCol})");
            }
        }
    }
}
