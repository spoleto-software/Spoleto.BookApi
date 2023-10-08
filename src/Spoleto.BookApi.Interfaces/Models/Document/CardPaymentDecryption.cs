using System;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// оплата платежной картой расшифровка платежа
    /// </summary>
    public class CardPaymentDecryption : PersistentObjectBase, ICardPaymentDecryption
    {
        /// <summary>
        /// СуммаПлатежа
        /// </summary>
        public decimal PaymentAmount { get; set; }

        /// <summary>
        /// СуммаВзаиморасчетов
        /// </summary>
        public decimal? SettlementAmount { get; set; }

        /// <summary>
        /// Ставка НДС
        /// </summary>
        public Vat VatValue { get; set; }

        /// <summary>
        /// Сумма НДС
        /// </summary>
        public decimal VatAmount { get; set; }

        /// <summary>
        /// Счет учета расчетов с контрагентом, Id
        /// </summary>
        public Guid ContractorSettlementAccountId { get; set; }

        /// <summary>
        /// Счет учета расчетов по авансам, Id
        /// </summary>
        public Guid AdvanceSettlementAccountId { get; set; }

        /// <summary>
        /// Договор с контрагентом, Id
        /// </summary>
        public Guid? DocumentReasonId { get; set; }

        /// <summary>
        /// Договор с контрагентом
        /// </summary>
        [RelatedKey(nameof(DocumentReasonId))]
        public IDocumentReason DocumentReason { get; set; }
    }
}
