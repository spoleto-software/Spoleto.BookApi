using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Подразделения организаций
    /// </summary>
    public class CompanyDivision : PersistentObjectBase, ICompanyDivision
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Префикс
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime DateCreate { get; set; }

        /// <summary>
        /// Дата закрытия
        /// </summary>
        public DateTime? DateClose { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string KPP { get; set; }

        /// <summary>
        /// Код по ОКПО
        /// </summary>
        public string OKPO { get; set; }

        /// <summary>
        /// Фирма, Id
        /// </summary>
        public Guid OwnerId { get; set; }

        /// <summary>
        /// Parent, Id
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        [RelatedKey(nameof(ParentId))]
        public ICompanyDivision Parent { get; set; }
    }
}
