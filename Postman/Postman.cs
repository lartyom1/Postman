using Postman.Classes;
using Postman.Interfaces;
using Postman.SendStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman
{
    public class Postman
    {
        private IMultiSender multiSender = new MultiSender();
        private UserRepository UserRepository = new UserRepository();

        public void AddUser(User user) => this.UserRepository.AddUser(user);

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
            List<Task> tasks = new List<Task>();
            foreach (var message in messages)
            {
                Task t = Task.Run(() =>
                {
                    var user = UserRepository.Get(message.UserId);
                    if (user != null)
                    {
                        bool sent = multiSender.Send((DeliveryMethod)user.DeliveryMethod, message.MessageText, user.Address);

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

            Task.WaitAll(tasks.ToArray());//i want to see results
        }
    }
}
