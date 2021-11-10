using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());

            while (queue.Count > 0)
            {
                if (quantOfFood - queue.Peek() >= 0)
                {
                    quantOfFood -= queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    return;
                }
            }
            if (quantOfFood >= 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
