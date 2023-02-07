using System;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using var firstReader = new StreamReader("text1.txt");
            using var secondReader = new StreamReader("text2.txt");

            using var writer = new StreamWriter("result.txt");
            string firstLine;
          
            while ((firstLine = firstReader.ReadLine()) != null)
            {
                writer.WriteLine(firstLine);
                string secondLine = secondReader.ReadLine();
                writer.WriteLine(secondLine);
            }
        }
    }
}
