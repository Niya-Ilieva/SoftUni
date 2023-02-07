using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rowSize][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = colElements;
            }
            for (int rows = 0; rows < jaggedArray.Length - 1; rows++)
            {
                if (jaggedArray[rows].Length == jaggedArray[rows + 1].Length)
                {
                    jaggedArray[rows] = jaggedArray[rows].Select(n => n *= 2).ToArray();
                    jaggedArray[rows + 1] = jaggedArray[rows + 1].Select(n => n *= 2).ToArray();
                }
                else
                {
                    jaggedArray[rows] = jaggedArray[rows].Select(n => n /= 2).ToArray();
                    jaggedArray[rows + 1] = jaggedArray[rows + 1].Select(n => n /= 2).ToArray();
                }
            }
            while (true)
            {
                string[] commandSplits = Console.ReadLine().Split();
                string cmd = commandSplits[0];
                if (cmd == "End")
                {
                    foreach (var line in jaggedArray)
                    {
                        Console.WriteLine(string.Join(" ", line));
                    }
                    break;
                }
                int row = int.Parse(commandSplits[1]);
                int col = int.Parse(commandSplits[2]);
                int value = int.Parse(commandSplits[3]);
                if (cmd == "Add")
                {
                    if (col >= 0 && col < jaggedArray[1].Length && row >= 0 && row < jaggedArray.Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                if (cmd == "Subtract")
                {
                    if (col >= 0 && col < jaggedArray[1].Length && row >= 0 && row < jaggedArray.Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }
        }
    }
}
