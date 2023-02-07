using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cup = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottle = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var cups = new Stack<int>(cup.Reverse());
            var bottles = new Stack<int>(bottle);

            int wastedWather = 0;
            int cupsCapacityLeft = 0;

            while (bottles.Count > 0)
            {
                if (cups.Count == 0)
                {
                    break;
                }
                int currentCup = cups.Pop();
                int currentBottle = bottles.Pop();
                if (currentCup <= currentBottle)
                {
                    wastedWather += currentBottle - currentCup;
                    
                }
                if (currentCup > currentBottle)
                {
                    cupsCapacityLeft = currentCup - currentBottle;
                    cups.Push(cupsCapacityLeft);
                }

            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWather}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ",cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWather}");
            }
        }
    }
}
