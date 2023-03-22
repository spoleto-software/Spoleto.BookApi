using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class ContactInfo : PersistentObjectBase, IContactInfo
    {
        /// <summary>
        /// Тип контакта
        /// </summary>
        public ContactType ContactType { get; set; }

        /// <summary>
        /// Представление
        /// </summary>
        public string View { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Регион
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// АдресЭП
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Доменное Имя Сервера
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Номер Телефона
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Номер телефона без кодов
        /// </summary>
        public string PhoneWithoutCode { get; set; }
    }
}
