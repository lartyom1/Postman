using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.SendStrategy
{
    internal class MultiSender : IMultiSender
    {
        public bool Send(DeliveryMethod sendMethod, string message, string adress)
        {
            switch (sendMethod)
            {
                case DeliveryMethod.SMS:  return new SmsStrategy().Send(message, adress);
                case DeliveryMethod.Email: return new EmailStrategy().Send(message, adress);
                default: return false;
            }
        }
    }
}
