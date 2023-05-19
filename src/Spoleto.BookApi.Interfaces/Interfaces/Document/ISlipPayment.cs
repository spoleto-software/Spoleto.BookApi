using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Оплата в чеке
    /// </summary>
    public interface ISlipPayment : IPersistentDocument
    {
        int LineNumber  { get; set; }

        /// <summary>
        /// Вид оплаты, Id
        /// </summary>
        Guid PaymentTypeContractorId { get; set; }

        /// <summary>
        /// Вид оплаты
        /// </summary>
        [RelatedKey(nameof(PaymentTypeContractorId))]
        IPaymentTypeContractor PaymentTypeContractor { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        decimal Amount { get; set; }
    }
}
