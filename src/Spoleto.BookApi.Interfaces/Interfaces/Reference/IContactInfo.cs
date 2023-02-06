using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Контактная информация
    /// </summary>
    public interface IContactInfo : IPersistentReference
    {
        /// <summary>
        /// Тип контакта
        /// </summary>
        ContactType ContactType { get; set; }

        /// <summary>
        /// Представление
        /// </summary>
        string View { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        string Country { get; set; }
      
        /// <summary>
        /// Регион
        /// </summary>
        string Region { get; set; }
   
        /// <summary>
        /// Город
        /// </summary>
        string City { get; set; }
      
        /// <summary>
        /// АдресЭП
        /// </summary>
        string Email { get; set; }
      
        /// <summary>
        /// Доменное Имя Сервера
        /// </summary>
        string ServerName { get; set; }

        /// <summary>
        /// Номер Телефона
        /// </summary>
        string Phone { get; set; }
      
        /// <summary>
        /// Номер телефона без кодов
        /// </summary>
        string PhoneWithoutCode { get; set; }

    }
}
