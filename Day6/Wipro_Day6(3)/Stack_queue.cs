using System;
using System.Collections.Generic;

namespace Wipro_Day6_3
{
    public class LambdaDemo
    {
        public static void Run()
        {
            List<int> numbers = new List<int> { 3, 5, 81, 45, 32, 15, 70 };

            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            List<int> greaterThan10 = numbers.FindAll(n => n > 10);

            Console.WriteLine("Numbers greater than 10 using lambda expression:");
            foreach (int n in greaterThan10)
            {
                Console.WriteLine(n);
            }
        }
    }
}
