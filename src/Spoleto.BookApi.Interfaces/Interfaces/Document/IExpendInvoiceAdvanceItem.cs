using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public interface IExpendInvoiceAdvanceItem : IPersistentObjectBase
    {
        decimal Amount { get; set; }

        decimal VatAmount { get; set; }

        Vat VatValue { get; set; }
    }
}
