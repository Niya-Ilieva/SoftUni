using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isMatch = false;
            var stack = new Stack<char>();

            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                    {
                        stack.Push(input[i]);
                    }
                    else
                    {
                        char current = stack.Pop();
                        if (input[i] == ')' && current == '(')
                        {
                            isMatch = true;
                        }
                        else if (input[i] == ']' && current == '[')
                        {
                            isMatch = true;
                        }
                        else if (input[i] == '}' && current == '{')
                        {
                            isMatch = true;
                        }
                        else
                        {
                            isMatch = false;
                            break;
                        }
                    }
                }
            }
            if (isMatch == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
