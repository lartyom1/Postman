
using Postman.Interfaces;

namespace Postman.SendStrategy
{
    /// <summary>
    /// Стратегия отправки sms
    /// </summary>
    public class SmsStrategy : ISender
    {
        private SemaphoreSlim smsSemaphore = new SemaphoreSlim(3, 3);

        /// <summary>
        /// Отправка sms
        /// </summary>
        /// <param name="message"> Текст сообщения </param>
        /// <param name="address"> Адрес </param>
        /// <returns></returns>
        public bool Send(string message, string address)
        {
            smsSemaphore.Wait();
            try
            {
                Thread.Sleep(1500);
                //some possibly faulty send email logic
                Console.WriteLine($"sending sms: {message} to: {address}");
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                smsSemaphore.Release();
            }
        }

    }
}
