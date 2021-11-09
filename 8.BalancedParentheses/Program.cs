using System;
using System.Collections.Generic;

namespace _8.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] balance = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            
            for (int i = 0; i < balance.Length; i++)
            {
                bool isOpen = balance[i] == '(' || balance[i] == '[' || balance[i] == '{';

                if (isOpen)
                {
                    stack.Push(balance[i]);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        bool isRound = stack.Peek() == '(' && balance[i] == ')';
                       
                        bool isCurly = stack.Peek() == '{' && balance[i] == '}'; 
                        
                        bool isSquare = stack.Peek() == '[' && balance[i] == ']';

                        if (isRound || isCurly || isSquare)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        stack.Push(balance[i]);
                    }
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
