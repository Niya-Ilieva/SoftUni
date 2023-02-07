using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine($"{names.Count} people remaining.");
                    break;
                }
                if (input == "Paid")
                {
                    foreach (var name in names)
                    {
                        Console.WriteLine(name);
                    }
                    names.Clear();
                }
                else
                {
                    names.Enqueue(input);
                }
            }
        }
    }
}
