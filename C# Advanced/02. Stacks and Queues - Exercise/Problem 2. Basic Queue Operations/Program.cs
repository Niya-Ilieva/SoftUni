using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbsToEnqueue = int.Parse(input[0]);
            var numbsToDequeue = int.Parse(input[1]);
            var numbToFind = int.Parse(input[2]);

            var queue = new Queue<int>(numbers);

            for (int i = 0; i < numbsToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Any())
            {
                if (queue.Contains(numbToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    var smallest = queue.Min();
                    Console.WriteLine(smallest);
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
