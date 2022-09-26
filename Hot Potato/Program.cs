using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            int tossing = int.Parse(Console.ReadLine());
            Queue<string> que = new Queue<string>(kids);
            int tossed = 1;
            while (que.Count > 1)
            {
                string currKid = que.Dequeue();
                if (tossed == tossing)
                {
                    Console.WriteLine($"Removed {currKid}");
                    tossed = 1;
                    continue;
                }
                tossed++;
                que.Enqueue(currKid);
            }

            Console.WriteLine($"Last is {que.Dequeue()}");
        }
    }
}
