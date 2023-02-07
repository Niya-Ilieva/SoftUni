using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
             string words = File.ReadAllText("words.txt");
             var input = File.ReadAllLines("input.txt");
            var timesContainedWords = new Dictionary<string, int>();
            using var writer = new StreamWriter("result.txt");
            string[] inputWord = words.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in inputWord)
            {
                timesContainedWords.Add(word, 0);
            }

            for (int i = 0; i < input.Length; i++)
            {
                string[] currnetLine = input[i].ToLower().Split(' ', '-', ',', '.', '!', '?');
                for (int j   = 0; j < currnetLine.Length; j++)
                {
                    if (timesContainedWords.ContainsKey(currnetLine[j]))
                    {
                        timesContainedWords[currnetLine[j]] += 1;
                    }
                }
              
            }
            foreach (var (key, value) in timesContainedWords.OrderByDescending(v => v.Value))
            {
                writer.WriteLine($"{key} = {value}");
            }
        }

    }
}
