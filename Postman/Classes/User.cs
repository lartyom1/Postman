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
        public string Id { get; set; }//=> throw new NotImplementedException();

        public int DeliveryMethod { get; set; }//=> throw new NotImplementedException();

        public string Address { get; set; } //=> throw new NotImplementedException();

        public User(int id, int deliveryMethod, string address)
        {
            Id = Id;
            DeliveryMethod = deliveryMethod;
            Address = address;
        }
    }
}
