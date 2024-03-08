using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.SendStrategy
{
    public class EmailStrategy : ISender
    {
        private SemaphoreSlim emailSemaphore = new SemaphoreSlim(3, 3);
        public bool Send(string message, string address)
        {
            emailSemaphore.Wait();
            try
            {
                //some possibly faulty send email logic
                Console.WriteLine($"sending email: {message} to: {address}");
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                emailSemaphore.Release();
            }
        }
    }
}
