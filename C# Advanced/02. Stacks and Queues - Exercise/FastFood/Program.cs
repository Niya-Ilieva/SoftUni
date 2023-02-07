using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(orders);

            int biggestOrder = queue.Max();
            Console.WriteLine(biggestOrder);

            for (int i = 0; i < orders.Length; i++)
            {
                int current = orders[i];

                if (quantityOfFood - current >= 0 && queue.Count > 0)
                {
                    quantityOfFood -= current;
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(", ", queue)}");
                    return;
                }
            }
                Console.WriteLine("Orders complete");
        }
    }
}
