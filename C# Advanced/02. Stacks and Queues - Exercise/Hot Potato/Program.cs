using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split();
            var toss = int.Parse(Console.ReadLine());

            Queue<string> names = new Queue<string>(kids);

            int counter = 1;

            while (names.Count > 1)
            {
                var currentName = names.Dequeue();

                if (counter == toss)
                {
                    Console.WriteLine($"Removed {currentName}");
                    counter = 0;
                }
                else
                {
                    names.Enqueue(currentName);
                }
                counter++;

            }
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
