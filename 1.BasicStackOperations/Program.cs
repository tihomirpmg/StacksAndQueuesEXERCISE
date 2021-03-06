using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = keys[0]; 
            int s = keys[1]; 
            int x = keys[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            while (true)
            {
                if (s <= stack.Count)
                {
                    for (int i = 0; i < s; i++)
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        Console.WriteLine("0");
                        break;
                    }
                }
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                    break;
                }
                else
                {
                    Console.WriteLine(stack.Min());
                    break;
                }
            }
        }
    }
}
