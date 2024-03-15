using Postman.Interfaces;

namespace Postman.SendStrategy
{
    /// <summary>
    /// Отправшик сообщений
    /// </summary>
    public class MultiSender : IMultiSender
    {
        private SemaphoreSlim multiSemaphore = new SemaphoreSlim(4, 4);
        private readonly Dictionary<DeliveryMethod, ISender> senders = new Dictionary<DeliveryMethod, ISender>()
        {
            { DeliveryMethod.SMS, new SmsStrategy()},
            { DeliveryMethod.Email, new EmailStrategy()}
        };

        /// <summary>
        /// Отправка сообщения
        /// </summary>
        /// <param name="sendMethod"> Метод отправки </param>
        /// <param name="message"> Текст сообщения </param>
        /// <param name="adress"> Адрес </param>
        /// <returns> fasle в случае ошибки </returns>
        public bool Send(DeliveryMethod sendMethod, string message, string adress)
        {
            var state = false;
            Console.WriteLine($"msg: {message} to: {adress} qued");

            multiSemaphore.Wait();
            if (senders.ContainsKey(sendMethod))//TRYGETVALUE
            {
                state = senders[sendMethod].Send(message, adress);
            }            
            multiSemaphore.Release();

            return state;
        }
    }
}
