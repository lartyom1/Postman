using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Classes.Send
{
    public class SendSms : ISender
    {
        public bool Send(string message, string address)
        {
            try
            {
                //some possibly faulty send sms logic
                Console.WriteLine($"sending sms: {message} to: {address}");
                return true;
            }
            catch { return false; }
        }
    }
}
