using System;
using System.Collections.Generic;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();

            foreach (var letter in input)
            {
                stack.Push(letter);
            }

            Console.WriteLine(string.Join("", stack));
        }
    }
}
