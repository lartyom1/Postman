using Postman.Classes.Send;
using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.SendStrategy
{
    public class EmailStrategy : IMultiSender
    {
        public bool Send(DeliveryMethod sendMethod, string message, string adress)
            => new SendSms().Send(message, adress);
    }
}
