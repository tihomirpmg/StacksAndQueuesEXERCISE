﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] cupsArray = Console.ReadLine().Split().Select(short.Parse).ToArray();
            Queue<short> cups = new Queue<short>(cupsArray);

            short[] bottlesArray = Console.ReadLine().Split().Select(short.Parse).ToArray();
            Stack<short> bottles = new Stack<short>(bottlesArray);
            short leanWater = 0;

            while (cups.Any() && bottles.Any())
            {
                if (bottles.Peek() >= cups.Peek())
                {
                    leanWater += (short)(bottles.Pop() - cups.Dequeue());
                }
                else
                {
                    short cup = cups.Peek();
                    while (cup > 0)
                    {
                        cup -= bottles.Pop();
                        if (cup < 0)
                        {
                            leanWater += Math.Abs(cup);
                        }
                    }
                    cups.Dequeue();
                }
            }
            if (cups.Any() == false)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
            }
            else if (bottles.Any() == false)
            {
                Console.WriteLine($"Cups: {string.Join(' ', cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {leanWater}");
        }
    }
}
