using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    ///  Счет-Фактура на поступление товара
    /// </summary>
    public class SupplyInvoice : Invoice
    {
        /// <summary>
        /// НДС предъявлен к вычету
        /// </summary>
        public bool VatdDeductible {get;set;}
    }
}
