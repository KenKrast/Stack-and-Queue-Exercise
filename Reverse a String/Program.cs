using System;
using System.Collections;
using System.Collections.Generic;

namespace Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string stringReverse = Console.ReadLine();

           Stack<char> reverse = new Stack<char>();

           foreach (var item in stringReverse)
           {
               reverse.Push(item);
           }

           foreach (var item in reverse)
           {
              Console.Write(item); 
           }
        }

    }
}
