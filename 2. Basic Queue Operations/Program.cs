using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numToAdd = commands[0];
            int numToRemove = commands[1];
            int numToLookFor = commands[2];
            int[] queSequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> que = new Queue<int>(queSequence);
            for (int i = 0; i < numToRemove; i++)
            {
                que.Dequeue();
            }

            if (que.Contains(numToLookFor))
            {
                Console.WriteLine("true");
            }
            else if (que.Count == 0)
            {
                Console.WriteLine(que.Count);
            }
            else
            {
                Console.WriteLine(que.Min());
            }
        }
    }
}
