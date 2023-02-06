using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Product : Item, IProduct
    {
        /// <summary>
        /// Тип маркировки
        /// </summary>
        public MarkingType? MarkingType { get; set; }

        /// <summary>
        /// Единица измерения, Id
        /// </summary>
        public Guid UnitId { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        public IUnit Unit { get; set; }

        /// <summary>
        /// Производитель, Id
        /// </summary>
        public Guid ManufacturerId { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        public IContractor Manufacturer { get; set; }

        /// <summary>
        /// Импортер, Id
        /// </summary>
        public Guid ImporterId { get; set; }

        /// <summary>
        /// Импортер
        /// </summary>
        public IContractor Importer { get; set; }

        /// <summary>
        /// КодТНВЭД, Id
        /// </summary>
        public Guid TNVEDId { get; set; }

        /// <summary>
        /// КодТНВЭД
        /// </summary>
        public ITNVED TNVED { get; set; }
    }
}
