using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int counts = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < counts; i++)
            {
                var command = Console.ReadLine().Split().ToArray();
                if (command[0] == "1")
                {
                    stack.Push(int.Parse(command[1]));
                }
                if (command[0] == "2")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }                   
                }
                if (command[0] == "3")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                if(command[0] == "4")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
