using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Classes
{
    public class UserRepository : IUserRepository
    {
        public IUser Get(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
