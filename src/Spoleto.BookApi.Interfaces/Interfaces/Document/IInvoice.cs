using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Счет-Фактура
    /// </summary>
    public interface IInvoice : IPersistentDocument
    {
        /// <summary>
        /// Номер
        /// </summary>
        string Number { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime Date { get; set; }

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
        /// Договор с контрагентом, Id
        /// </summary>
        Guid? DocumentReasonId { get; set; }

        /// <summary>
        /// Контрагент
        /// </summary>
        [RelatedKey(nameof(DocumentReasonId))]
        IDocumentReason DocumentReason { get; set; }

        /// <summary>
        /// Валюта, Id
        /// </summary>
        Guid CurrencyId { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        [RelatedKey(nameof(CurrencyId))]
        ICurrency Currency { get; set; }

        /// <summary>
        /// Ответственное лицо, Id
        /// </summary>
        Guid CreatedEmployeeId { get; set; }

        /// <summary>
        /// Сумма документа
        /// </summary>
        decimal TotalAmount { get; set; }

        /// <summary>
        /// Сумма НДС
        /// </summary>
        decimal VatAmount { get; set; }

        /// <summary>
        /// Документ-основание, Id
        /// </summary>
        Guid DocumentId { get; set; }

        /// <summary>
        /// Тип документа-основания
        /// </summary>
        DocumentType DocumentType { get; set; }
        
        /// <summary>
        /// Код вида операции
        /// </summary>
        int? OperationCode { get; set; }

        /// <summary>
        /// Код способа получения
        /// </summary>
        int? ReceiptTypeCode { get; set; }
    }
}
