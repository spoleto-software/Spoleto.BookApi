using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Договоры с контрагентами
    /// </summary>
    public interface IDocumentReason : IPersistentReference
    {
        /// <summary>
        /// Полное наименование
        /// </summary>
        string FullName { get; set; }

        /// <summary>
        /// Организация, Id
        /// </summary>
        Guid LegalPersonId { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        [RelatedKey(nameof(LegalPersonId))]
        ILegalPerson LegalPerson { get; set; }

        /// <summary>
        /// Контрагент, Id
        /// </summary>
        Guid ContractorId { get; set; }

        /// <summary>
        /// Контрагент
        /// </summary>
        [RelatedKey(nameof(ContractorId))]
        IContractor Contractor { get; set; }

        /// <summary>
        /// Валюта, Id
        /// </summary>
        Guid? CurrencyId { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        [RelatedKey(nameof(CurrencyId))]
        ICurrency Currency { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime? Date { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        string Number { get; set; }

        /// <summary>
        /// Вид договора
        /// </summary>
        DocumentReasonType? DocumentReasonType { get; set; }

    }
}
