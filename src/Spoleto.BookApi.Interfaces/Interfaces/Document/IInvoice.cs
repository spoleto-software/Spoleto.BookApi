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
        /// Накладная-основание, Id
        /// </summary>
        Guid WaybillId { get; set; }

        /// <summary>
        /// Накладная-основание
        /// </summary>
        [RelatedKey(nameof(WaybillId))]
        IWaybill Waybill { get; set; }
    }
}
