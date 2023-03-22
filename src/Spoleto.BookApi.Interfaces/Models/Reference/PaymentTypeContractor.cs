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
        /// Parent, Id
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        [RelatedKey(nameof(ParentId))]
        public IPaymentTypeContractor Parent { get; set; }

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
