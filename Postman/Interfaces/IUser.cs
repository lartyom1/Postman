namespace Postman.Interfaces
{
    /// <summary>
    /// Перечисление способов доставки
    /// </summary>
    public enum DeliveryMethod
    {
        SMS,
        Email
    }

    /// <summary>
    /// Запись пользователя, которому будет отправляться сообщение
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        string Id { get; }
        /// <summary>
        /// Метод доставки сообщения, напаример:
        /// 0 -не нужна доставка, 1 - Телеграмм, 2 - СМС, 3 - e-mail, 4 - WhatsApp и тд и тп
        /// </summary>
        int DeliveryMethod { get; }
        /// <summary>
        /// Адресс, по которму будут отправляться сообщания. Зависит от метода доставки:
        /// аккаунт Телеграмм, номер телефона, e-mail и тд
        /// </summary>
        string Address { get; }
    }
}
