using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Оплата в чеке
    /// </summary>
    public class SlipPayment : PersistentObjectBase, ISlipPayment
    {

        public int LineNumber { get; set;  }

        /// <summary>
        /// Вид оплаты, Id
        /// </summary>
        public Guid PaymentTypeContractorId { get; set; }

        ///// <summary>
        ///// Вид оплаты
        ///// </summary>
        //public IPaymentTypeContractor PaymentTypeContractor { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        public decimal Amount { get; set; }
    }
}
