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
        /// Наименование
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Договор с контрагентом, Id
        /// </summary>
        Guid? DocumentReasonId { get; set; }

        /// <summary>
        /// Договор с контрагентом
        /// </summary>
        [RelatedKey(nameof(DocumentReasonId))]
        IDocumentReason DocumentReason { get; set; }
        
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
