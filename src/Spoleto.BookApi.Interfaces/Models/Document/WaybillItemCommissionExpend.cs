using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public class WaybillItemCommissionExpend : WaybillItemExpend, IWaybillItemCommissionExpend
    {
        /// <summary>
        /// Счет учета передачи на комиссию, Id
        /// </summary>
        public Guid CommissionAccountId { get; set; }
    }
}
