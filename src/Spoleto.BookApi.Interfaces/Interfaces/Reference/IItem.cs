using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public interface IItem : IPersistentReference
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Наименование полное
        /// </summary>
        string FullName { get; set; }

        ///// <summary>
        ///// Код
        ///// </summary>
        //string Code { get; set; }

        /// <summary>
        /// Артикул
        /// </summary>
        string Article { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        string Note { get; set; }

        /// <summary>
        /// Parent, Id
        /// </summary>
        Guid ParentId { get; set; }

        ///// <summary>
        ///// Parent
        ///// </summary>
        //[RelatedKey(nameof(ParentId))]
        //IItem Parent { get; set; }

    }
}
