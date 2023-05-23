﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Чек на продажу
    /// </summary>
    public interface ISaleSlip<T,V> : IBaseSlip
        where T: ISaleSlipItem
        where V: ISaleSlipPayment
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
