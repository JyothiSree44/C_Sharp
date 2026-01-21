using System;
using Wipro_Day11_1__SOLID.Interfaces;
using Wipro_Day11_1__SOLID.Services;

namespace Wipro_Day11_1__SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationService notificationService =
                new EmailNotificationService();

            ILoggerService loggerService =
                new FileLoggerService();

            OrderService orderService =
                new OrderService(notificationService, loggerService);

            orderService.PlaceOrder("Laptop");

            Console.ReadLine();
        }
    }
}