using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Счет-фактура
    /// </summary>
    public class SupplyInvoice : PersistentObjectBase, ISupplyInvoice
    {
        /// <summary>
        /// Номер
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Связанные накладные на поставку
        /// </summary>
        public List<Guid> SupplyWaybills { get; set; }
    }
}
