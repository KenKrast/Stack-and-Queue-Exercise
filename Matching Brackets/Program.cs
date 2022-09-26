using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            
            Stack<int> index = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    index.Push(i);
                }
                if (expression[i] == ')')
                {
                    int startIndex = index.Pop();
                    Console.WriteLine(expression.Substring(startIndex, i - startIndex + 1));
                }

            }
        }
    }
}
