using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var stack = new Stack<char>();

            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            Console.WriteLine(string.Join("",stack));
        }
    }
}
