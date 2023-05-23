using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Чек на возврат
    /// </summary>
    public class ReturnSlip : BaseSlip, IReturnSlip<ReturnSlipItem, ReturnSlipPayment>
    {
        /// <summary>
        /// Позиции чека
        /// </summary>
        public List<ReturnSlipItem> SlipItems { get; set; }

        /// <summary>
        /// Оплаты в чеке
        /// </summary>
        public List<ReturnSlipPayment> SlipPayments { get; set; }
    }
}
