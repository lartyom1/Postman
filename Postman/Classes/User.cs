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
        public string Id { get; set; }

        public int DeliveryMethod { get; set; }

        public string Address { get; set; }

        public User(string id, int deliveryMethod, string address)
        {
            Id = id;
            DeliveryMethod = deliveryMethod;
            Address = address;
        }
    }
}
