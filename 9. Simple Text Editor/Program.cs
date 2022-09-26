using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO: Implement Redo functionality.

            Stack<string> memory = new Stack<string>();
            StringBuilder text = new StringBuilder();
            int operationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < operationsCount; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                string cmdType = cmdArg[0];

                if (cmdType == "1")
                {
                    string cmdValue = cmdArg[1];
                    text.Append(cmdValue);
                    memory.Push(text.ToString());
                }
                else if (cmdType == "2")
                {
                    int charectersRemove = int.Parse(cmdArg[1]);
                    text = text.Remove(text.Length - charectersRemove, charectersRemove);
                    memory.Push(text.ToString());

                    //Alternative code below;

                    //string modifiedString = text.ToString().Substring(0, text.Length - charectersRemove);
                    //text = new StringBuilder(modifiedString);
                }
                else if (cmdType == "3")
                {
                    int index = int.Parse(cmdArg[1]);
                    if (index >= 1 && index <= text.Length)
                    {
                        Console.WriteLine(text[index - 1]);
                    }
                }
                else if (cmdType == "4")
                {
                    memory.Pop();
                    string previousVersion = memory.Peek();
                    text = new StringBuilder(previousVersion);
                }
            }

        }
    }
}
