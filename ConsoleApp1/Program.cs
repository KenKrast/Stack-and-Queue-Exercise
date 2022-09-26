using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Key_Revolve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bulletInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] lockInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int reward = int.Parse(Console.ReadLine());
          
            Queue<int> locks = new Queue<int>(lockInfo);
            Stack<int> bullets = new Stack<int>(bulletInfo);

            int bulletShot = 0;
            while (bullets.Any() && locks.Any())
            {
              StartShooting(locks, bullets, ref bulletShot, barrelSize);  
            }

            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int earnedMoney = reward - bulletShot * bulletPrice;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
            }
        }

        static void StartShooting(Queue<int> locks, Stack<int> bullets, ref int bulletShot, int barrelSize)
        {

            int bulletSize = bullets.Pop();
            int lockSize = locks.Peek();
            bulletShot++;

            if (bulletSize <= lockSize)
            {
                locks.Dequeue();
                Console.WriteLine("Bang!");
            }
            else
            {
                Console.WriteLine("Ping!");
            }

            if (bulletShot % barrelSize == 0 && bullets.Any())
            {
                Console.WriteLine("Reloading!");
            }
        }
    }
}
