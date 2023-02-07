using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();

            var stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var operators = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                int result = 0;

                if (operators == "+")
                {
                    result = firstNumber + secondNumber;
                }
                else if (operators == "-")
                {
                    result = firstNumber - secondNumber;
                }

                stack.Push(result.ToString());
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
