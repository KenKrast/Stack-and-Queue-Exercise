using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string revered = String.Empty;
            for (int i = name.Length -1; i > -1; i--)
            {
                revered += name[i];
            }
            Console.WriteLine(revered);
        }

    }
}
