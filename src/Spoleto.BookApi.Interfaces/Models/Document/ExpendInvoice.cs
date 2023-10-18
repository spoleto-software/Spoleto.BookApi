using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    ///  Счет-Фактура на реализацию товара
    /// </summary>
    public class ExpendInvoice : Invoice, IExpendInvoice
    {
        /// <summary>
        /// Вид счет-фактуры
        /// </summary>
      public ExpendInvoiceType ExpendInvoiceType { get; set; }
    }
}
