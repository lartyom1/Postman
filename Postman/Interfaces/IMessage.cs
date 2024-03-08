using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman.Interfaces
{
    /// <summary>
    /// Сообщение для доставки пользователю
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Идентификатор пользователя, которому надо доставить сообщение
        /// </summary>
        int UserId { get; }
        /// <summary>
        /// Текст сообщения
        /// </summary>
        string MessageText { get; }
    }
}
