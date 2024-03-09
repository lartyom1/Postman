using Postman.Interfaces;

namespace Postman.Classes
{
    public class User : IUser
    {
        public string Id { get; set; }
        public int DeliveryMethod { get; set; }
        public string Address { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        /// <param name="id"> id пользователя </param>
        /// <param name="deliveryMethod"> Способ доставки </param>
        /// <param name="address"> Адрес</param>
        public User(string id, int deliveryMethod, string address)
        {
            Id = id;
            DeliveryMethod = deliveryMethod;
            Address = address;
        }
    }
}
