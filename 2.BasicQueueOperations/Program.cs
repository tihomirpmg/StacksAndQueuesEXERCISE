using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
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
            Queue<int> queue = new Queue<int>(numbers);

            while (true)
            {
                if (s <= queue.Count)
                {
                    for (int i = 0; i < s; i++)
                    {
                        queue.Dequeue();
                    }

                    if (queue.Count == 0)
                    {
                        Console.WriteLine("0");
                        break;
                    }
                }
                if (queue.Contains(x))
                {
                    Console.WriteLine("true");
                    break;
                }
                else
                {
                    Console.WriteLine(queue.Min());
                    break;
                }
            }
        }
    }
}