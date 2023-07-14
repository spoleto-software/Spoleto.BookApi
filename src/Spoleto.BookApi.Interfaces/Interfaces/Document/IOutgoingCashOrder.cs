using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Расходный кассовый ордер
    /// </summary>
    public interface IOutgoingCashOrder<T> : ICashOrder
        where T : IOutgoingPaymentDecryption
    {
        /// <summary>
        /// ВидОперации
        /// </summary>
        OutgoingCashOrderType OutgoingCashOrderType { get; set; }

        /// <summary>
        /// Банковский счет, Id
        /// </summary>
        Guid? BankAccountId { get; set; }

        /// <summary>
        /// Банковский счет
        /// </summary>
        [RelatedKey(nameof(BankAccountId))]
        IBankAccount BankAccount { get; set; }

        /// <summary>
        /// Расшифровка платежа
        /// </summary>
        List<T> PaymentDecryptions { get; set; }

    }
}
