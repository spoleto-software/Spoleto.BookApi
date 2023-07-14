using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Приходный кассовый ордер
    /// </summary>
    public interface IIncomingCashOrder<T> : ICashOrder
        where T: IIncomingPaymentDecryption
    {
        /// <summary>
        /// ВидОперации
        /// </summary>
        IncomingCashOrderType IncomingCashOrderType { get; set; }

        /// <summary>
        ///ПринятоОт
        /// </summary>
        string TakenFrom { get; set; }

        /// <summary>
        /// Расшифровка платежа
        /// </summary>
        List<T> PaymentDecryptions { get; set; }

    }
}
