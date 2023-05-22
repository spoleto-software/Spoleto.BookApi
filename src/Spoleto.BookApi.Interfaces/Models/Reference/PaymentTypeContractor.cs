using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Связь видов оплат с контрагентами
    /// </summary>
    public class PaymentTypeContractor : PersistentObjectBase, IPaymentTypeContractor
    {
        /// <summary>
        /// Вид оплаты
        /// </summary>
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Процент банковской комиссии
        /// </summary>
        public decimal BankCommissionPercent { get; set; }

        /// <summary>
        /// Договор с контрагентом, Id
        /// </summary>
        public Guid? DocumentReasonId { get; set; }

        /// <summary>
        /// Договор с контрагентом
        /// </summary>
        [RelatedKey(nameof(DocumentReasonId))]
        public IDocumentReason DocumentReason { get; set; }

        /// <summary>
        /// Организация, Id
        /// </summary>
        public Guid LegalPersonId { get; set; }

        /// <summary>
        /// Контрагент, Id
        /// </summary>
        public Guid ContractorId { get; set; }


        /// <summary>
        /// Контрагент
        /// </summary>
        [RelatedKey(nameof(ContractorId))]
        public IContractor Contractor { get; set; }
    }
}
