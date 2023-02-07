using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullets = int.Parse(Console.ReadLine());
            int sizeOfBarrel = int.Parse(Console.ReadLine());
            int[] bullet = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfInteligence = int.Parse(Console.ReadLine());
            int barellCounter = 0;
            var bullets = new Stack<int>(bullet);
            var locks = new Queue<int>(locs);
            int shots = 0;
            while (locks.Count > 0)
            {
                if (bullets.Count > 0)
                {
                    int currentBullet = bullets.Pop();
                    int currnetLock = locks.Peek();
                    barellCounter++;
                    if (currentBullet <= currnetLock)
                    {
                        locks.Dequeue();
                        Console.WriteLine("Bang!");
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                    shots++;
                }
                if (barellCounter == sizeOfBarrel && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    barellCounter = 0;
                }
                if (bullets.Count == 0)
                {
                    break;
                }
            }
            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueOfInteligence - (priceOfBullets * shots)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
