using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("text.txt");
            using var writer = new StreamWriter("textWithNumbers.txt");

            string line = reader.ReadLine();
            int counter = 1;

            while (line != null)
            {
                writer.WriteLine($"{counter}. {line}");
                counter++;
                line = reader.ReadLine();
            }
        }
    }
}
