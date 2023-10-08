using System;
using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class CardPayment : PersistentObjectBase, ICardPayment<CardPaymentDecryption>
    {
        /// <summary>
        /// ВидОперации
        /// </summary>
        public CardPaymentType CardPaymentType { get; set; }

         /// <summary>
        /// СуммаПлатежа
        /// </summary>
        public decimal PaymentAmount { get; set; }

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
        /// Тип контрагента
        /// </summary>
        public CashContractorType ContractorType { get; set; }


        /// <summary>
        /// Договор с контрагентом, Id
        /// </summary>
        public Guid? DocumentReasonId { get; set; }

        /// <summary>
        /// Договор с контрагентом
        /// </summary>
        [RelatedKey(nameof(DocumentReasonId))]
        public IDocumentReason DocumentReason { get; set; }

        /// <summary>
        /// Подразделение организации, Id
        /// </summary>
        public Guid CompanyDivisionId { get; set; }

        /// <summary>
        ///  Подразделение организации
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionId))]
        public ICompanyDivision CompanyDivision { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Сотрудник, создавший накладную (ответственный), Id
        /// </summary>
        public Guid CreatedEmployeeId { get; set; }

        /// <summary>
        /// Валюта, Id
        /// </summary>
        public Guid? CurrencyId { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        [RelatedKey(nameof(CurrencyId))]
        public ICurrency Currency { get; set; }

        ///// <summary>
        ///// Сумма
        ///// </summary>
        //decimal? Amount { get; set; }

        /// <summary>
        /// Счет Касса,  Id
        /// </summary>
        public Guid? CashAccountId { get; set; }

        /// <summary>
        /// Документ-основание, Id
        /// </summary>
        public Guid? DocumentId { get; set; }

        /// <summary>
        /// Тип документа-основания
        /// </summary>
        public DocumentType DocumentType { get; set; }

        /// <summary>
        /// Вид оплаты, Id
        /// </summary>
        public Guid PaymentTypeContractorId { get; set; }

        /// <summary>
        /// Вид оплаты
        /// </summary>
        [RelatedKey(nameof(PaymentTypeContractorId))]
        public IPaymentTypeContractor PaymentTypeContractor { get; set; }

        /// <summary>
        /// Банковский счет, Id
        /// </summary>
        public Guid? BankAccountId { get; set; }

        /// <summary>
        /// Банковский счет
        /// </summary>
        [RelatedKey(nameof(BankAccountId))]
        public IBankAccount BankAccount { get; set; }

        /// <summary>
        /// Контрагент-банк, Id
        /// </summary>
        public Guid BankContractorId { get; set; }

        /// <summary>
        /// Контрагент-банк
        /// </summary>
        [RelatedKey(nameof(BankContractorId))]
        public IContractor BankContractor { get; set; }

        /// <summary>
        /// Договор эквайринга, Id
        /// </summary>
        public Guid? BankDocumentReasonId { get; set; }

        /// <summary>
        /// Договор эквайринга
        /// </summary>
        [RelatedKey(nameof(BankDocumentReasonId))]
        public IDocumentReason BankDocumentReason { get; set; }

        /// <summary>
        /// РасшифровкаПлатежа
        /// </summary>
        public List<CardPaymentDecryption> CardPaymentDecryptions { get; set; }
    }
}
