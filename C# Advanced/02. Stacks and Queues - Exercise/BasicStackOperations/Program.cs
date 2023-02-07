using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbersToPush =int.Parse(input[0]);
            var numbersToPop = int.Parse(input[1]);
            var numberToFind = int.Parse(input[2]);

            var stack = new Stack<int>(numbers);

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Any())
            {
                if (stack.Contains(numberToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int smallest = stack.Min();
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
