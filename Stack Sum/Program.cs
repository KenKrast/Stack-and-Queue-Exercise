using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            var command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                var splitted = command.Split();
                if (splitted[0] == "add")
                {
                    int num1 = int.Parse(splitted[1]);
                    int num2 = int.Parse(splitted[2]);
                    stack.Push(num1);
                    stack.Push(num2);
                }

                if (splitted[0] == "remove")
                {
                    int count = int.Parse(splitted[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Sum: " + stack.Sum());
        }
    }
}
