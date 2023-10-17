using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Счет-фактура
    /// </summary>
    public class Invoice : PersistentObjectBase, IInvoice
    {
        /// <summary>
        /// Номер
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Организация, Id
        /// </summary>
        public Guid LegalPersonId { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        [RelatedKey(nameof(LegalPersonId))]
        public ILegalPerson LegalPerson { get; set; }

        /// <summary>
        /// Контрагент, Id
        /// </summary>
        public Guid ContractorId { get; set; }

        /// <summary>
        /// Контрагент
        /// </summary>
        [RelatedKey(nameof(ContractorId))]
        public IContractor Contractor { get; set; }

        /// <summary>
        /// Договор с контрагентом, Id
        /// </summary>
        public Guid? DocumentReasonId { get; set; }

        /// <summary>
        /// Контрагент
        /// </summary>
        [RelatedKey(nameof(DocumentReasonId))]
        public IDocumentReason DocumentReason { get; set; }

        /// <summary>
        /// Валюта, Id
        /// </summary>
        public Guid CurrencyId { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        [RelatedKey(nameof(CurrencyId))]
        public ICurrency Currency { get; set; }

        /// <summary>
        /// Ответственное лицо, Id
        /// </summary>
        public Guid CreatedEmployeeId { get; set; }

        /// <summary>
        /// Сумма документа
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Сумма НДС
        /// </summary>
        public decimal VatAmount { get; set; }

        /// <summary>
        /// Документ-основание, Id
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
        /// Тип документа-основания
        /// </summary>
        public DocumentType? DocumentType { get; set; }

        /// <summary>
        /// Код вида операции
        /// </summary>
        public int? OperationCode { get; set; }

        /// <summary>
        /// Код способа получения
        /// </summary>
        public int? ReceiptTypeCode { get; set; }
    }
}
