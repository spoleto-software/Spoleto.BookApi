using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{

    /// <summary>
    /// Расшифровка платежа
    /// </summary>
    public class PaymentDecryption : PersistentObjectBase, IPaymentDecryption
    {
        /// <summary>
        /// СпособыПогашенияЗадолженности
        /// </summary>
        public DebtRepaymentType DebtRepaymentType { get; set; }

        /// <summary>
        /// СуммаПлатежа
        /// </summary>
        public decimal? PaymentAmount { get; set; }


        /// <summary>
        /// СуммаВзаиморасчетов
        /// </summary>
        public decimal? SettlementAmount { get; set; }

        /// <summary>
        /// СтавкаНДС
        /// </summary>
        public Vat VatValue { get; set; }

        /// <summary>
        /// СуммаНДС
        /// </summary>
        public decimal? VatAmount { get; set; }

        /// <summary>
        /// Счет учета расчетов с контрагентом, Id
        /// </summary>
        public Guid ContractorSettlementAccountId { get; set; }


        /// <summary>
        /// Счет учета расчетов по авансам, Id
        /// </summary>
        public Guid AdvanceSettlementAccountId { get; set; }
    }
}
