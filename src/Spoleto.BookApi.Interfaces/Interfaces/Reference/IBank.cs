using System;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Банк
    /// </summary>
    public interface IBank : IPersistentReference
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// КоррСчет
        /// </summary>
        string CorrespondentAccount { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// Телефоны
        /// </summary>
        string Phones { get; set; }


        /// <summary>
        /// СВИФТБИК
        /// </summary>
        string SwiftBIK { get; set; }


        /// <summary>
        /// Parent, Id
        /// </summary>
        Guid ParentId { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        [RelatedKey(nameof(ParentId))]
        IBank Parent { get; set; }

        /// <summary>
        /// Страна, Id
        /// </summary>
        Guid CountryId { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        [RelatedKey(nameof(CountryId))]
        ICountry Country { get; set; }
    }
}
