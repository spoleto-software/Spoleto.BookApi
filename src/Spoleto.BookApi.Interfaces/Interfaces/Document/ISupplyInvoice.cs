using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Счет-Фактура на поступление товара
    /// </summary>
    public interface ISupplyInvoice : IInvoice
    {
        /// <summary>
        /// НДС предъявлен к вычету
        /// </summary>
        bool VatdDeductible {get;set;}
    }
}
