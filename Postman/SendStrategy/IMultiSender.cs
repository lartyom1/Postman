using Postman.Interfaces;

namespace Postman.SendStrategy
{
    internal interface IMultiSender
    {
        /// <summary>
        /// Отправка сообщения
        /// </summary>
        /// <param name="sendMethod"> Метод отправки </param>
        /// <param name="message"> Текст сообщения </param>
        /// <param name="adress"> Адрес </param>
        /// <returns> false в случае ошибки </returns>
        public bool Send(DeliveryMethod sendMethod, string message, string adress);
    }
}
