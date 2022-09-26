using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _6_Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] startSong  = Console.ReadLine()
                .Split(", ");
            Queue<string> songs = new Queue<string>(startSong);

            while (songs.Count > 0)
            {
                string[] command = Console.ReadLine()
                    .Split();
                string commandType = command[0];

                if (commandType == "Play")
                {
                    songs.Dequeue();
                }
                else if (commandType == "Add")
                {
                    
                    string addSong = String.Join(" ", commandType.Skip(1));
                    if (songs.Contains(addSong))
                    {
                        Console.WriteLine($"{addSong} is already contained!");
                        continue;
                    }
                    songs.Enqueue(addSong);
                }
                else if(commandType == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
            }
        }
    }
}
