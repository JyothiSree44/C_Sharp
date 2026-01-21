using System;
using System.IO;

namespace Wipro_Day12_SecureUserApp.Services
{
    public static class LoggerService
    {
        private static readonly string logFile = "application.log";

        public static void Log(string message)
        {
            File.AppendAllText(
                logFile,
                DateTime.Now + " : " + message + Environment.NewLine
            );
        }
    }
}
