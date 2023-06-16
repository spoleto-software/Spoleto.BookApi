using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public interface IWaybillItemCommissionExpend :IWaybillItemExpend
    {
        /// <summary>
        /// Счет учета передачи на комиссию, Id
        /// </summary>
        Guid CommissionAccountId { get; set; }
    }
}
