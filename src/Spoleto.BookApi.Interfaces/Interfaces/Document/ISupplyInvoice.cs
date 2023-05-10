using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Счет-Фактура
    /// </summary>
    public interface ISupplyInvoice : IPersistentDocument
    {
        /// <summary>
        /// Номер
        /// </summary>
        string Number { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Связанные накладные на поставку
        /// </summary>
        List<Guid> SupplyWaybills { get; set; }

    }
}
