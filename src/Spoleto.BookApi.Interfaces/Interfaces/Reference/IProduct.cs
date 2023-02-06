using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public interface IProduct : IItem
    {

        /// <summary>
        /// Тип маркировки
        /// </summary>
        MarkingType? MarkingType { get; set; }

        /// <summary>
        /// Единица измерения, Id
        /// </summary>
        Guid UnitId { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [RelatedKey(nameof(UnitId))]
        IUnit Unit { get; set; }

        /// <summary>
        /// Производитель, Id
        /// </summary>
        Guid ManufacturerId { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        [RelatedKey(nameof(ManufacturerId))]
        IContractor Manufacturer { get; set; }

        /// <summary>
        /// Импортер, Id
        /// </summary>
        Guid ImporterId { get; set; }

        /// <summary>
        /// Импортер
        /// </summary>
        [RelatedKey(nameof(ImporterId))]
        IContractor Importer { get; set; }
        
        /// <summary>
        /// КодТНВЭД, Id
        /// </summary>
        Guid TNVEDId { get; set; }

        /// <summary>
        /// КодТНВЭД
        /// </summary>
        [RelatedKey(nameof(TNVEDId))]
        ITNVED TNVED { get; set; }
    }
}
