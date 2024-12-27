using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal class SmsNotificationService : INotificationService
    {
        public SmsNotificationService() { }

        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"{recipient} you received a new SMS: {message}");
        }
    }
}
