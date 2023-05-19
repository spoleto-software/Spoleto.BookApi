using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class Bank : PersistentObjectBase, IBank
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// КоррСчет
        /// </summary>
        public string CorrespondentAccount { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Телефоны
        /// </summary>
        public string Phones { get; set; }


        /// <summary>
        /// СВИФТБИК
        /// </summary>
        public string SwiftBIK { get; set; }


        /// <summary>
        /// Parent, Id
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        [RelatedKey(nameof(ParentId))]
        public IBank Parent { get; set; }

        /// <summary>
        /// Страна, Id
        /// </summary>
        public Guid CountryId { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        [RelatedKey(nameof(CountryId))]
        public ICountry Country { get; set; }
    }
}
