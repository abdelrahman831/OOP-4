using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    internal interface INotificationService
    {

        public void SendNotification(string recipient, string message);
    }
}
