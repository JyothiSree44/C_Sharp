using System;
using System.Collections.Generic;
using System.Text;
using Wipro_Day11_1__SOLID.Interfaces;

namespace Wipro_Day11_1__SOLID.Services
{
    public class OrderService
    {
        private readonly INotificationService _notificationService;
        private readonly ILoggerService _loggerService;

        public OrderService(INotificationService notificationService,
                            ILoggerService loggerService)
        {
            _notificationService = notificationService;
            _loggerService = loggerService;
        }

        public void PlaceOrder(string productName)
        {
            _loggerService.Log("Order placed for " + productName);
            _notificationService.Send("Your order for " + productName + " is confirmed");
        }
    }
}
