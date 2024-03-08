using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Classes.Send
{
    class SendEmail : ISender
    {
        public bool Send(string message, string address)
        {
            try
            {
                //some possibly faulty send email logic
                Console.WriteLine($"sending email: {message} to: {address}");
                return true;
            }
            catch { return false; }
        }
    }
}
