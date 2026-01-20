using System;
using System.Collections.Generic;

namespace Wipro_Day6_3
{
    public class StackDemo
    {
        public static void Run()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Popped Value: " + stack.Pop());
            Console.WriteLine("Top Value: " + stack.Peek());
            Console.WriteLine("Stack contains 20: " + stack.Contains(20));
            Console.WriteLine("Current Count: " + stack.Count);

            stack.Clear();
            Console.WriteLine("Stack cleared. Current Count after clearing: " + stack.Count);
        }
    }
}
