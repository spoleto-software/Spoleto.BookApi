using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Расшифровка платежа
    /// </summary>
    public interface IPaymentDecryption : IPersistentDocument
    {
        /// <summary>
        /// СпособыПогашенияЗадолженности
        /// </summary>
        DebtRepaymentType DebtRepaymentType { get; set; }

        /// <summary>
        /// СуммаПлатежа
        /// </summary>
        decimal? PaymentAmount { get; set; }


        /// <summary>
        /// СуммаВзаиморасчетов
        /// </summary>
        decimal? SettlementAmount { get; set; }

        /// <summary>
        /// СтавкаНДС
        /// </summary>
        Vat VatValue { get; set; }

        /// <summary>
        /// СуммаНДС
        /// </summary>
        decimal? VatAmount { get; set; }

        /// <summary>
        /// Счет учета расчетов с контрагентом, Id
        /// </summary>
        Guid ContractorSettlementAccountId { get; set; }


        /// <summary>
        /// Счет учета расчетов по авансам, Id
        /// </summary>
        Guid AdvanceSettlementAccountId { get; set; }

        /// <summary>
        /// СтатьяДвиженияДенежныхСредств, Id
        /// </summary>
        Guid? CashFlowItemId { get; set; }

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
        /// Документ-основание
        /// </summary>
        Guid? DocumentId {get;set;}

        /// <summary>
        /// Тип документа-основания
        /// </summary>
        DocumentType? DocumentType { get; set; }

}
}
