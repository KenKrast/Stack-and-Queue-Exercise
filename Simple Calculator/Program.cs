using System;
using System.Collections.Generic;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
             var expression = Console.ReadLine().Split();

             Stack<string> stack = new Stack<string>();

             for (int i = 0; i < expression.Length; i++)
             {
                stack.Push(expression[i]);
                if (stack.Count == 3)
                {
                    int first = int.Parse(stack.Pop());
                    string symbol = stack.Pop();
                    int third = int.Parse(stack.Pop());
                    int result = 0;
                    if (symbol == "+")
                    {
                        result = first + third;
                    }

                    if (symbol == "-")
                    {
                        result = third - first;
                    }
                    stack.Push((result.ToString()));
                }
             }

             Console.WriteLine(stack.Pop());
        }
    }
}
