using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public interface ICompanyDivision : IPersistentReference
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Префикс
        /// </summary>
        string Prefix { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        DateTime DateCreate { get; set; }

        /// <summary>
        /// Дата закрытия
        /// </summary>
        DateTime? DateClose { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        string KPP { get; set; }

        /// <summary>
        /// Код по ОКПО
        /// </summary>
        string OKPO { get; set; }

        /// <summary>
        /// Фирма, Id
        /// </summary>
        Guid OwnerId { get; set; }

        /// <summary>
        /// Parent, Id
        /// </summary>
        Guid ParentId { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        [RelatedKey(nameof(ParentId))]
        ICompanyDivision Parent { get; set; }


        //описать список<RefПодразделенияОрганизаций_КонтактнаяИнформация>
    }
}
