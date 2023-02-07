using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boxes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCapacity = int.Parse(Console.ReadLine());
            int racks = 0;
            int sum = 0;

            var stack = new Stack<int>(boxes);

            while (stack.Count > 0)
            {
                int current = stack.Peek();
                sum += current;
                if (sum <= maxCapacity)
                {
                    stack.Pop();
                    if (sum == maxCapacity)
                    {
                        racks++;
                        sum = 0;
                    }
                }
                else
                {
                    racks++;
                    sum = current;
                    stack.Pop();
                }
            }
            if (sum > 0)
            {
                racks++;
            }
            Console.WriteLine(racks);
        }
    }
}
