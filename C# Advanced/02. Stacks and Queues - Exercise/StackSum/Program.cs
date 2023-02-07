using System;
using System.Linq;
using System.Collections.Generic;

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
                string[] command = Console.ReadLine().ToLower().Split();

                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "add")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (command[0] == "remove")
                {
                    int timesToRemoveNumber = int.Parse(command[1]);

                    if (timesToRemoveNumber < stack.Count)
                    {
                        for (int i = 0; i < timesToRemoveNumber; i++)
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
