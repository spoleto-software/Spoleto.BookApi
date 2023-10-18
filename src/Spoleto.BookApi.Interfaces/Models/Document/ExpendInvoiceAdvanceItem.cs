using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class ExpendInvoiceAdvanceItem : PersistentObjectBase, IExpendInvoiceAdvanceItem
    {
        public decimal Amount { get; set; }

        public decimal VatAmount { get; set; }

        public Vat VatValue { get; set; }
    }
}
