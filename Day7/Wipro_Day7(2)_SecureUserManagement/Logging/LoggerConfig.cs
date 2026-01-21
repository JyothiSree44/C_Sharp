using Serilog;

namespace Wipro_Day7_2_SecureUserManagement.Logging
{
    public static class LoggerConfig
    {
        public static void Configure()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("logs/app.log")
                .CreateLogger();
        }
    }
}
