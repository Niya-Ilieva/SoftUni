using System;
using System.Linq;

namespace Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaggedRows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[jaggedRows][];

            for (int rows = 0; rows < jaggedRows; rows++)
            {
                int[] col = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[rows] = col;
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] commandSplits = input.Split();
                string command = commandSplits[0];
                int row = int.Parse(commandSplits[1]);
                int col = int.Parse(commandSplits[2]);
                int value = int.Parse(commandSplits[3]);
                if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged.Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (command == "Add")
                {
                    jagged[row][col] += value;
                }
               else if (command == "Subtract")
                {
                    jagged[row][col] -= value;
                }
            }
            foreach (var row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
