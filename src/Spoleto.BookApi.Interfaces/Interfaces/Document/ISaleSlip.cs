using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Чек на продажу
    /// </summary>
    public interface ISaleSlip : IBaseSlip
    {
        /// <summary>
        /// Позиции чека
        /// </summary>
        IEnumerable<ISlipItem> SlipItems { get; set; }

        /// <summary>
        /// Оплаты в чеке
        /// </summary>
        IEnumerable<ISlipPayment> SlipPayments { get; set; }
    }
}
