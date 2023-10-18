using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    ///  Счет-Фактура на реализацию товара
    /// </summary>
    public interface IExpendInvoice : IInvoice
    {
        /// <summary>
        /// Вид счет-фактуры
        /// </summary>
        ExpendInvoiceType ExpendInvoiceType { get; set;  }
    }
}
