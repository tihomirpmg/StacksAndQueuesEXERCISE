using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int racks = 1;
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            
            Stack<int> stack = new Stack<int>(values);
            int sum = 0;
            while (stack.Count > 0)
            {
                sum += stack.Peek();
                if (sum <= capacity)
                {
                    stack.Pop();
                }
                else if (sum > capacity)
                {
                    sum = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
