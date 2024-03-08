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
        private SemaphoreSlim multiSemaphore = new SemaphoreSlim(5, 5);
        private readonly Dictionary<DeliveryMethod, ISender> senders = new Dictionary<DeliveryMethod, ISender>()
        {
            { DeliveryMethod.SMS, new SmsStrategy()},
            { DeliveryMethod.Email, new EmailStrategy()}
        };

        public bool Send(DeliveryMethod sendMethod, string message, string adress)
        {
            bool state = false;
            Console.WriteLine($"msg: {message} to: {adress} qued");

            multiSemaphore.Wait();
            Console.WriteLine($"msg: {message} to: {adress} sending");
            switch (sendMethod)
            {
                case DeliveryMethod.SMS: state = senders[sendMethod].Send(message, adress); break;
                case DeliveryMethod.Email: state = senders[sendMethod].Send(message, adress); break;
                default: break;
            }
            multiSemaphore.Release();

            return state;
        }
    }
}
