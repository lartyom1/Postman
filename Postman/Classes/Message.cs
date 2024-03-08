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
        public int UserId => throw new NotImplementedException();

        public string MessageText => throw new NotImplementedException();
    }
}
