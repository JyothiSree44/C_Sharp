using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Day10_7__DesignPatterns.Singleton
{
    public sealed class Logger
    {
        // Single instance created once
        private static readonly Logger _instance = new Logger();

        // Private constructor prevents external creation
        private Logger()
        {
        }

        // Global access point
        public static Logger Instance
        {
            get { return _instance; }
        }

        public void Log(string message)
        {
            Console.WriteLine("LOG: " + message);
        }
    }
}
