
using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.SendStrategy
{
    internal class SmsStrategy : ISender
    {
        private SemaphoreSlim smsSemaphore = new SemaphoreSlim(3, 3);
        public bool Send(string message, string address)
        {
            smsSemaphore.Wait();
            try
            {
                //some possibly faulty send email logic
                Console.WriteLine($"sending sms: {message} to: {address}");
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                smsSemaphore.Release();
            }
        }

    }
}
