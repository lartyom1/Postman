using Postman.Interfaces;

namespace Postman.Classes
{
    public class UserRepository : IUserRepository
    {
        private readonly Dictionary<string, User> _user = new Dictionary<string, User>();
        public IUser Get(int userId) => _user.ContainsKey(userId.ToString()) ?
            _user[userId.ToString()] : null;

        /// <summary>
        /// Добавление пользователя в репозиторий
        /// </summary>
        /// <param name="user"> Пользователь </param>
        /// <returns> Результат добавления, false если пользователь уже есть </returns>
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
