using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Расходный кассовый ордер
    /// </summary>
    public class OutgoingCashOrder : CashOrder, IOutgoingCashOrder<OutgoingPaymentDecryption>
    {
        /// <summary>
        /// ВидОперации
        /// </summary>
        public OutgoingCashOrderType OutgoingCashOrderType { get; set; }

        /// <summary>
        /// Банковский счет, Id
        /// </summary>
        public Guid? BankAccountId { get; set; }

        /// <summary>
        /// Банковский счет
        /// </summary>
        [RelatedKey(nameof(BankAccountId))]
        public IBankAccount BankAccount { get; set; }

        /// <summary>
        /// Расшифровка платежа
        /// </summary>
        public List<OutgoingPaymentDecryption> PaymentDecryptions { get; set; }
    }
}
