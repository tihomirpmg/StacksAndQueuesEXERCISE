using System;
using System.Collections.Generic;

namespace _6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(songs);
            string cmd = Console.ReadLine();

            while (queue.Count > 0)
            {
                if (cmd.Contains("Play"))
                {
                    if (queue.Count > 0)
                    {
                        queue.Dequeue();
                    }
                }
                else if (cmd.Contains("Add"))
                {
                    string song = cmd.Remove(0, 4);
                    if (queue.Contains(song) == false)
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
