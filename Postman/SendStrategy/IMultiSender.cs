using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.SendStrategy
{
    internal interface IMultiSender
    {
        public bool Send(DeliveryMethod sendMethod, string message, string adress);
    }
}
