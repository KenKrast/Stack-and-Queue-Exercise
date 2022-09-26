using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] stackArg = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int number = stackArg[0]; The problem to solve has a mistake
            int remove = stackArg[1];
            int itemCheck = stackArg[2];
            int[] elementeToAppend = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(elementeToAppend);

            for (int i = 0; i < remove; i++)
            {
                stack.Pop();
            }
            CheckMethod(stack, itemCheck);
        }

        static void CheckMethod(Stack<int> stack, int itemCheck)
        {

            if (stack.Contains(itemCheck))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(stack.Count);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
 