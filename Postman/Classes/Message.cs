using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Classes
{
    public class Message : IMessage
    {
        public int UserId { get; set; }
        public string MessageText { get; set; }

        public Message(int uid, string message)
        {
            UserId = uid;
            MessageText = message;
        }
    }
}
