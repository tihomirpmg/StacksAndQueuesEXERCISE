using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string txt = string.Empty;

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (cmd[0])
                {
                    case "1":
                        stack.Push(txt);
                        txt += cmd[1];
                        break;

                    case "2":
                        stack.Push(txt);
                        int count = int.Parse(cmd[1]);
                        txt = txt.Substring(0, txt.Length - count);
                        break;

                    case "3":
                        Console.WriteLine(txt[int.Parse(cmd[1]) - 1]);
                        break;

                    case "4":
                        txt = stack.Pop();
                        break;
                }
            }
        }
    }
}
