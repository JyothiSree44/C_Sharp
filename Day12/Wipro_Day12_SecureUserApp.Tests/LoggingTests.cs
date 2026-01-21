using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Wipro_Day12_SecureUserApp.Services;

namespace Wipro_Day12_SecureUserApp.Tests
{
    [TestClass]
    public class LoggingTests
    {
        [TestMethod]
        public void Log_File_Should_Be_Created()
        {
            LoggerService.Log("Test log message");

            Assert.IsTrue(File.Exists("application.log"));
        }
    }
}
