using System;
using System.Collections.Generic;
using System.Text;
using Wipro_Day11_1__SOLID.Interfaces;

namespace Wipro_Day11_1__SOLID.Services
{
    public class FileLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine("Log Saved: " + message);
        }
    }
}
