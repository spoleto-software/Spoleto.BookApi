using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Связь видов оплат с контрагентами
    /// </summary>
    public interface IPaymentTypeContractor : IPersistentReference
    {
        /// <summary>
        /// Вид оплаты
        /// </summary>
        PaymentType PaymentType { get; set; }

        /// <summary>
        /// Parent, Id
        /// </summary>
        Guid ParentId { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        [RelatedKey(nameof(ParentId))]
        IPaymentTypeContractor Parent { get; set; }
        
        /// <summary>
        /// Организация, Id
        /// </summary>
        Guid LegalPersonId { get; set; }

        /// <summary>
        /// Контрагент, Id
        /// </summary>
        Guid ContractorId { get; set; }


        /// <summary>
        /// Контрагент
        /// </summary>
        [RelatedKey(nameof(ContractorId))]
        IContractor Contractor { get; set; }  
    }
}
