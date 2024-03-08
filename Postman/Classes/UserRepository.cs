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

        private Dictionary<string, User> _user = new Dictionary<string, User>();

        //? why would you ever use string id for user and get by int id
        public IUser Get(int userId) => _user.ContainsKey(userId.ToString()) ?
            _user[userId.ToString()] : null;

        public bool AddUser(User user)
        {
            if (!_user.ContainsKey(user.Id))
            {
                _user.Add(user.Id, user);
                return true;
            }

            return false;
        }

        public void DeleteUser() => throw new NotImplementedException();
        public void UpdateUser() => throw new NotImplementedException();
        //etc
    }
}
