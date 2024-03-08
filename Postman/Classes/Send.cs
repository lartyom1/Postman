using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Classes
{
    public class Send : ISender
    {
        bool ISender.Send(string message, string address)
        {
            throw new NotImplementedException();
        }
    }
}
