using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Оборудование
    /// </summary>
    public interface IStuff : IItem
    {
        /// <summary>
        /// Единица измерения, Id
        /// </summary>
        Guid? UnitId { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [RelatedKey(nameof(UnitId))]
        IUnit Unit { get; set; }
    }
}
