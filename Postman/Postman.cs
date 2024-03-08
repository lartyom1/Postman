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
        }
    }
}
