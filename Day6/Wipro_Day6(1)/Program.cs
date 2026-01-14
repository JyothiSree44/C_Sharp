using System;
using System.Collections.Generic;

namespace Wipro_day6_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack that can hold integer values
            Stack<int> stack = new Stack<int>();

            // Step 2: Push values onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Step 3: Pop a value from the stack
            int poppedValue = stack.Pop();
            Console.WriteLine("Popped Value: " + poppedValue);

            // Step 4: Peek at the top value
            int topValue = stack.Peek();
            Console.WriteLine("Top Value: " + topValue);

            // Step 5: Check if the stack contains a specific value
            bool contains20 = stack.Contains(20);
            Console.WriteLine("Stack contains 20: " + contains20);

            // Step 6: Display current count
            int count = stack.Count;
            Console.WriteLine("Current Count: " + count);

            // Step 7: Clear the stack
            stack.Clear();
            Console.WriteLine("Stack cleared. Current Count: " + stack.Count);
        }
    }
}
