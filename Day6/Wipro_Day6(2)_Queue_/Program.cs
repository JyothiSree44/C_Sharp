using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> nameQueue = new Queue<string>();
        Queue<int> ageQueue = new Queue<int>();

        // Enqueue
        nameQueue.Enqueue("Jyothi");
        nameQueue.Enqueue("Chinni");

        ageQueue.Enqueue(22);
        ageQueue.Enqueue(25);

        // Dequeue
        Console.WriteLine("Name: " + nameQueue.Dequeue());
        Console.WriteLine("Age: " + ageQueue.Dequeue());
    }
}
