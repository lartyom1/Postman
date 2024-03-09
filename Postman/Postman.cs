using Postman.Classes;
using Postman.Interfaces;
using Postman.SendStrategy;

namespace Postman
{
    /// <summary>
    /// Отправляет сообщения из списка messages пользователям
    /// Сообщение отправляется методом, указанным в записи пользователя
    /// по адресу, указанным в записи пользователя
    /// В случае, если сообщение не удалось доставить, помещает его в FailedMessages
    /// </summary>
    public class Postman
    {
        private IMultiSender multiSender = new MultiSender();
        private UserRepository UserRepository = new UserRepository();

        /// <summary>
        /// Добавление пользователя в репозиторий Postman
        /// </summary>
        /// <param name="user"></param>
        /// <returns> false если пользователь уже есть </returns>
        public bool AddUser(User user) => this.UserRepository.AddUser(user);

        /// <summary>
        /// Список, куда следует поместить все сообщения, которые не удалось доставить
        /// </summary>
        public IEnumerable<IMessage> FailedMessages = new List<Message>();
        /// <summary>
        /// Отправляет сообщения из списка messages пользователям
        /// Сообщение отправляется методом, указанным в записи пользователя
        /// по адресу, указанным в записи пользователя
        /// В случае, если сообщение не удалось доставить, помещает его в FailedMessages
        /// </summary>
        /// <param name="messages"> коллекция сообщений </param>
        public void Send(IEnumerable<IMessage> messages)
        {
            var tasks = new List<Task>();
            foreach (var message in messages)
            {
                var t = Task.Run(() =>
                {
                    var user = UserRepository.Get(message.UserId);
                    if (user != null)
                    {
                        var sent = multiSender.Send((DeliveryMethod)user.DeliveryMethod, message.MessageText, user.Address);

                        if (!sent)
                        {
                            FailedMessages = FailedMessages.Append(message);//smth else happened
                            Console.WriteLine($"msg: {message.MessageText} to: {user.Address} failed");
                        }
                        else
                        {
                            Console.WriteLine($"msg: {message.MessageText} to: {user.Address} sent at: {DateTime.Now}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"msg: {message.MessageText} to: unknown user failed");
                        FailedMessages = FailedMessages.Append(message);//non existent user
                    }
                });
                //t.Wait();//make synchronous
                tasks.Add(t);
            }

            Task.WaitAll(tasks.ToArray());
        }
    }
}
