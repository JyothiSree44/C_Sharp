using System;
using System.Collections.Generic;
using System.Text;
using Wipro_Day11_1__SOLID.Interfaces;

namespace Wipro_Day11_1__SOLID.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email Sent: " + message);
        }
    }

}
