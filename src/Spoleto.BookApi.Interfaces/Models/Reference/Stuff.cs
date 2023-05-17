using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Оборудование
    /// </summary>
    public class Stuff : Item, IStuff
    {
        /// <summary>
        /// Единица измерения, Id
        /// </summary>
        public Guid? UnitId { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [RelatedKey(nameof(UnitId))]
        public IUnit Unit { get; set; }
    }
}
