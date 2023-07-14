using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Приходный кассовый ордер
    /// </summary>
    public class IncomingCashOrder : CashOrder, IIncomingCashOrder<IncomingPaymentDecryption>
    {
        /// <summary>
        /// ВидОперации
        /// </summary>
        public IncomingCashOrderType IncomingCashOrderType { get; set; }

        /// <summary>
        ///ПринятоОт
        /// </summary>
        public string TakenFrom { get; set; }

        /// <summary>
        /// Расшифровка платежа
        /// </summary>
        public List<IncomingPaymentDecryption> PaymentDecryptions { get; set; }
    }
}
