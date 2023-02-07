using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesCarsCanPass = int.Parse(Console.ReadLine());
            int totalCarsCrossed = 0;
            var carsQueue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine($"{totalCarsCrossed} cars passed the crossroads.");
                    break;
                }
                if (input == "green")
                {
                    if (carsQueue.Count < timesCarsCanPass)
                    {
                        timesCarsCanPass = carsQueue.Count;                        
                    }
                    for (int i = 0; i < timesCarsCanPass; i++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        totalCarsCrossed++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }
            }
        }
    }
}
