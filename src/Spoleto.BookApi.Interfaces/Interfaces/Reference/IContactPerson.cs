using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public interface IContactPerson : IPersistentReference
    {
        /// <summary>
		/// Фамилия
		/// </summary>
        string Surname { get; set; }
      
        /// <summary>
        /// Имя
        /// </summary>
        string Name { get; set; }
       
        /// <summary>
        /// Отчество
        /// </summary>
        string Patronymic { get; set; }
    
        /// <summary>
        /// ДатаРождения
        /// </summary>
        DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        string Post { get; set; }
       
        /// <summary>
        /// Описание
        /// </summary>
        string Description { get; set; }
       
        /// <summary>
        /// Владелец
        /// </summary>
        string Owner { get; set; }
      
        /// <summary>
        /// Вид контактного лица
        /// </summary>
        string ContactPersonType { get; set; }

        /// <summary>
        /// Контактная информация
        /// </summary>
       List<IContactInfoContactPerson> ContactInfo { get; set; }
    
    }
}
