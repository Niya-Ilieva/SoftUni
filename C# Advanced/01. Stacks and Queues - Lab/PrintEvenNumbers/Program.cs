using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(numbers);

            Console.WriteLine(string.Join(", ", queue.Where(n => n % 2 == 0)));
        }
    }
}
