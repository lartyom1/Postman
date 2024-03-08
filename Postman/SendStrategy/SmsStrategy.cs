using Postman.Classes.Send;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.SendStrategy
{
    internal class SmsStrategy : IMultiSender
    {
        public bool Send(string message, string adress) => new SendEmail().Send(message, adress);
        
    }
}
