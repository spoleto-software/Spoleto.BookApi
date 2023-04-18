using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Номенклатура
    /// </summary>
    public class Item : PersistentObjectBase, IItem
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Наименование полное
        /// </summary>
        public string FullName { get; set; }

        ///// <summary>
        ///// Код
        ///// </summary>
        //public string Code { get; set; }

        /// <summary>
        /// Артикул
        /// </summary>
        public string Article { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Parent, Id
        /// </summary>
        public Guid ParentId { get; set; }

        ///// <summary>
        ///// Parent
        ///// </summary>
        //public IItem Parent { get; set; }

        public Guid ItemTypeId { get; set; }

        /// <summary>
        /// Вид ставки НДС
        /// </summary>
        public VatType VatType { get; set; }
    }
}
