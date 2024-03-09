using Postman.Interfaces;

namespace Postman.SendStrategy
{
    /// <summary>
    /// Стратегия для отправки email
    /// </summary>
    public class EmailStrategy : ISender
    {
        private SemaphoreSlim emailSemaphore = new SemaphoreSlim(3, 3);
        
        /// <summary>
        /// Отправка email
        /// </summary>
        /// <param name="message"> Текст сообщения </param>
        /// <param name="address"> Адрес </param>
        /// <returns> false в случае ошибки </returns>
        public bool Send(string message, string address)
        {
            emailSemaphore.Wait();
            try
            {
                Thread.Sleep(1500);
                //some possibly faulty send email logic
                Console.WriteLine($"sending email: {message} to: {address}");
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                emailSemaphore.Release();
            }
        }
    }
}
