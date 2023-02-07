using System;
using System.Linq;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaggedArrayRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[jaggedArrayRows][];

            int currentwidth = 1;

            for (int row = 0; row < jaggedArrayRows; row++)
            {

                jaggedArray[row] = new int[currentwidth];
                int[] currnetRow = jaggedArray[row];
                currnetRow[0] = 1;
                currnetRow[currentwidth - 1] = 1;
  
                if (currnetRow.Length > 2)
                {
                    for (int i = 1; i < currnetRow.Length - 1; i++)
                    {
                        int[] previousRow = jaggedArray[row - 1];
                        int sumOfPreviousRows = previousRow[i - 1] + previousRow[i];
                        currnetRow[i] = sumOfPreviousRows;
                    }
                }
                currentwidth++;

            }
            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}