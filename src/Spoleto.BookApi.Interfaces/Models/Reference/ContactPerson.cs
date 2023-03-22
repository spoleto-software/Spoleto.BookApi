using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Контактное лицо
    /// </summary>
    public class ContactPerson : PersistentObjectBase, IContactPerson
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// ДатаРождения
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Владелец
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Вид контактного лица
        /// </summary>
        public string ContactPersonType { get; set; }

        /// <summary>
        /// Контактная информация
        /// </summary>
        public List<IContactInfoContactPerson> ContactInfo { get; set; }
    }
}
