using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("Text.txt");
            using var writer = new StreamWriter("result.txt");
            string line = reader.ReadLine();

            int counter = 0;

            while (line != null)
            {
                if (counter % 2 == 1)
                {
                    writer.WriteLine(line);
                }
                counter++;
                line = reader.ReadLine();
            }
        }
    }
}
