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

        SemaphoreSlim multiSemaphore = new SemaphoreSlim(0, 5);

        //SemaphoreSlim smsSemaphore = new SemaphoreSlim(0, 3);
        //SemaphoreSlim emailSemaphore = new SemaphoreSlim(0, 3);
        public bool Send(DeliveryMethod sendMethod, string message, string adress)
        {
            multiSemaphore.Wait();
            var state = false;
            switch (sendMethod)
            {
                case DeliveryMethod.SMS: state = new SmsStrategy().Send(sendMethod, message, adress); break;
                case DeliveryMethod.Email: state = new EmailStrategy().Send(sendMethod, message, adress); break;
                default: break;
            }
            multiSemaphore.Release();
            return state;
        }
    }
}
