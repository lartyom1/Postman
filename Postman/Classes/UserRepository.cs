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

        private List<User> _user = new List<User>();
        public IUser Get(int userId)
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            _user.Add(user);        
        }

        public void DeleteUser() => throw new NotImplementedException();
    }
}
