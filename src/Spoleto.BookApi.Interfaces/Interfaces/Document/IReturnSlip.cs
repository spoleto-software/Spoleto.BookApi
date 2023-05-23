using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Чек на возврат
    /// </summary>
    public interface IReturnSlip<T, V> : IBaseSlip
        where T : IReturnSlipItem
        where V : IReturnSlipPayment
    {
        /// <summary>
        /// Позиции чека
        /// </summary>
        List<T> SlipItems { get; set; }

        /// <summary>
        /// Оплаты в чеке
        /// </summary>
        List<V> SlipPayments { get; set; }
    }
}
