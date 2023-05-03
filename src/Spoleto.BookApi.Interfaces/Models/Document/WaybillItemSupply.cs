using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиции накладной на поставку
    /// </summary>
    public class WaybillItemSupply : WaybillItem, IWaybillItemSupply
    {
        /// <summary>
        /// Способ учета НДС
        /// </summary>
        public VatAccountingType? VatAccountingType { get; set; }

    }
}
