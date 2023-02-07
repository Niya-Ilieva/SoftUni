using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>();

            foreach (var numb in input)
            {
                if (numb % 2 == 0)
                {
                    numbers.Enqueue(numb);
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
