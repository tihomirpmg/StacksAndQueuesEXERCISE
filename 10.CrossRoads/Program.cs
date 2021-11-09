using System;
using System.Collections.Generic;

namespace _10.CrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine()); 
            int temp1 = greenLight;
            string cmd; 
            byte free= byte.Parse(Console.ReadLine());
            byte temp2 = free;
                                            
            Queue<string> line = new Queue<string>();

            byte carCounter = 0;
            while ((cmd = Console.ReadLine()) != "END")
            {
                if (cmd == "green")
                {
                    int n = line.Count;
                    for (int i = 0; i < n; i++)
                    {
                        if (greenLight == 0)
                        {
                            continue;
                        }

                        string peeked = line.Peek();
                        if (greenLight - peeked.Length > 0)
                        {
                            greenLight -= peeked.Length;
                            carCounter++;
                            line.Dequeue();
                        }
                        else
                        {
                            if (greenLight + free >= peeked.Length)
                            {
                                carCounter++;
                                line.Dequeue();
                                greenLight = 0;
                            }
                            else
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine("{0} was hit at {1}.", peeked, peeked[greenLight + free]);
                                return;
                            }
                        }

                    }
                    greenLight = temp1;
                    free = temp2;
                }
                else
                {
                    line.Enqueue(cmd);
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carCounter} total cars passed the crossroads.");
        }
    }
}
