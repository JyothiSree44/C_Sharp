using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Day10_7__DesignPatterns.Singleton;

namespace Wipro_Day10_7__DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Singleton Logger
            Logger.Instance.Log("Application started");
            Logger.Instance.Log("Singleton pattern executed");

            Console.ReadLine();
        }
    }
}
