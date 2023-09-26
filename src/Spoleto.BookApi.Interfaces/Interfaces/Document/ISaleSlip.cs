using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Net;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Чек на продажу
    /// </summary>
    public interface ISaleSlip<T,V,W> : IBaseSlip
        where T: ISaleSlipItem
        where V: ISaleSlipPayment
        where W: ISaleSlipGiftCard
    {
        /// <summary>
        /// Позиции чека
        /// </summary>
        List<T> SlipItems { get; set; }

        /// <summary>
        /// Проданные подарочные сертификаты
        /// </summary>
        List<W> SlipGiftCards { get; set; }

        /// <summary>
        /// Оплаты в чеке
        /// </summary>
        List<V> SlipPayments { get; set; }
    }
}
