using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(numbers);

            while (true)
            {
                string[] command = Console.ReadLine().ToLower().Split().ToArray();

                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "add")
                {
                    var firstNumber = int.Parse(command[1]);
                    var secondNumber = int.Parse(command[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (command[0] == "remove")
                {
                    var timesToRemove = int.Parse(command[1]);

                    if (stack.Count > timesToRemove)
                    {
                        for (int i = 0; i < timesToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
