using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public enum CardPaymentType
    {
        /// <summary>
        /// Оплата покупателя
        /// </summary>
        BuyerPayment,

        /// <summary>
        /// РОзничная выручка
        /// </summary>
        RetailRevenue,

        /// <summary>
        /// ВозвратПокупателю
        /// </summary>
        ReturnToBuyer,

        /// <summary>
        /// ПлатежПоРеестру
        /// </summary>
        PaymentByRegister
    }
}
