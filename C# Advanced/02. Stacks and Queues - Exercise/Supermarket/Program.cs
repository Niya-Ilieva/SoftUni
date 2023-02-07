using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customerce = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }
                else if (command == "Paid")
                {
                    if (customerce.Count >= 1)
                    {
                        foreach (var name in customerce)
                        {
                            Console.WriteLine(name);
                        }
                        customerce.Clear();
                    }
                }
                else
                {
                    customerce.Enqueue(command);
                }
            }
            Console.WriteLine($"{customerce.Count} people remaining.");
        }
    }
}
