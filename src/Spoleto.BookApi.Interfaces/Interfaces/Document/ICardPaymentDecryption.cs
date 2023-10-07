using System;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// оплата платежной картой расшифровка платежа
    /// </summary>
    public interface ICardPaymentDecryption : IPersistentObjectBase
    {
        /// <summary>
        /// СуммаПлатежа
        /// </summary>
        decimal PaymentAmount { get; set; }

        /// <summary>
        /// СуммаВзаиморасчетов
        /// </summary>
        decimal? SettlementAmount { get; set; }

        /// <summary>
        /// Ставка НДС
        /// </summary>
        Vat VatValue { get; set; }


        /// <summary>
        /// Сумма НДС
        /// </summary>
        decimal VatAmount { get; set; }


        /// <summary>
        /// Счет учета расчетов с контрагентом, Id
        /// </summary>
        Guid ContractorSettlementAccountId { get; set; }


        /// <summary>
        /// Счет учета расчетов по авансам, Id
        /// </summary>
        Guid AdvanceSettlementAccountId { get; set; }

    }
}
