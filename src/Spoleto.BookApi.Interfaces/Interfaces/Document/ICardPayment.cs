using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// оплата платежной картой
    /// </summary>
    public interface ICardPayment<T> : IPersistentDocument
        where T: ICardPaymentDecryption
    {
        /// <summary>
        /// ВидОперации
        /// </summary>
        CardPaymentType CardPaymentType { get; set; }

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
        /// Тип контрагента
        /// </summary>
        CashContractorType ContractorType { get; set; }


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
        /// Подразделение организации, Id
        /// </summary>
        Guid CompanyDivisionId { get; set; }

        /// <summary>
        ///  Подразделение организации
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionId))]
        ICompanyDivision CompanyDivision { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        string Number { get; set; }

        /// <summary>
        /// Сотрудник, создавший накладную (ответственный), Id
        /// </summary>
        Guid CreatedEmployeeId { get; set; }

        /// <summary>
        /// Валюта, Id
        /// </summary>
        Guid? CurrencyId { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        [RelatedKey(nameof(CurrencyId))]
        ICurrency Currency { get; set; }

        ///// <summary>
        ///// Сумма
        ///// </summary>
        //decimal? Amount { get; set; }

        /// <summary>
        /// Счет Касса,  Id
        /// </summary>
        Guid? CashAccountId { get; set; }

        /// <summary>
        /// Документ-основание, Id
        /// </summary>
        Guid? DocumentId { get; set; }

        /// <summary>
        /// Тип документа-основания
        /// </summary>
        DocumentType DocumentType { get; set; }

        /// <summary>
        /// Вид оплаты, Id
        /// </summary>
        Guid PaymentTypeContractorId { get; set; }

        /// <summary>
        /// Вид оплаты
        /// </summary>
        [RelatedKey(nameof(PaymentTypeContractorId))]
        IPaymentTypeContractor PaymentTypeContractor { get; set; }

        /// <summary>
        /// Банковский счет, Id
        /// </summary>
        Guid? BankAccountId { get; set; }

        /// <summary>
        /// Банковский счет
        /// </summary>
        [RelatedKey(nameof(BankAccountId))]
        IBankAccount BankAccount { get; set; }

        /// <summary>
        /// РасшифровкаПлатежа
        /// </summary>
        List<T> CardPaymentDecryptions { get; set; }
    }
}
