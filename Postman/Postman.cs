using Postman.Classes;
using Postman.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman
{
    public class Postman
    {
        public UserRepository UserRepository { get; set; }

        private const int maxSms = 5;
        private const int maaxEmail = 5;

        private const int maxSender = 7;

        /// <summary>
        /// Список, куда следует поместить все сообщения, которые не удалось доставить
        /// </summary>
        public IEnumerable<IMessage> FailedMessages;
        /// <summary>
        /// Отправляет сообщения из списка messages пользователям
        /// Сообщение отправляется методом, указанным в записи пользователя
        /// по адресу, указанным в записи пользователя
        /// В случае, если сообщение не удалось доставить, помещает его в FailedMessages
        /// </summary>
        /// <param name="messages"> коллекция сообщений </param>
        public void Send(IEnumerable<IMessage> messages)
        {
            foreach (var message in messages)
            {
                var user = UserRepository.Get(message.UserId);
                if (user != null)
                {

                    //strategy here
                    //limiter here
                    //?semaphore
                }
                else
                {
                    FailedMessages.Append(message);//non existent user
                }

            }

        }
    }
}
