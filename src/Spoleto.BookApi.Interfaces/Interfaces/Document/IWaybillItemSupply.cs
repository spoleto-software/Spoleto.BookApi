using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиции накладной на поставку
    /// </summary>
    public interface IWaybillItemSupply : IWaybillItem
    {
        /// <summary>
        /// Способ учета НДС
        /// </summary>
        VatAccountingType? VatAccountingType { get; set; }

    }
}
