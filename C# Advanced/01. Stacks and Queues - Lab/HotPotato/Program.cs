using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            int counts = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(names);
            int count = 0;

            while (queue.Count > 1)
            {
                string currentName = queue.Dequeue();
                count++;
                if (count == counts)
                {
                    Console.WriteLine($"Removed {currentName}");
                    count = 0;
                    continue;
                }              
                queue.Enqueue(currentName);
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
