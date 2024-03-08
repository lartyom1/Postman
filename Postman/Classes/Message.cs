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
        public int UserId { get; set; }//=> throw new NotImplementedException();
        public string MessageText { get; set; }//=> throw new NotImplementedException();

        public Message(int uid, string message)
        {
            UserId = uid;
            MessageText = message;
        }
    }
}
