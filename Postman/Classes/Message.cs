using Postman.Interfaces;

namespace Postman.Classes
{
    /// <summary>
    /// Сообщение для доставки пользователю
    /// </summary>
    public class Message : IMessage
    {
        public int UserId { get; set; }
        public string MessageText { get; set; }

        /// <summary>
        /// Сообщение для доставки пользователю
        /// </summary>
        /// <param name="uid"> id пользователя </param>
        /// <param name="message"> текст сообщения </param>
        public Message(int uid, string message)
        {
            UserId = uid;
            MessageText = message;
        }
    }
}
