using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Classes
{
    public class User : IUser
    {
        public string Id => throw new NotImplementedException();

        public int DeliveryMethod => throw new NotImplementedException();

        public string Address => throw new NotImplementedException();
    }
}
