using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Кассовый ордер
    /// </summary>
    public interface ICashOrder : IPersistentDocument
    {
        /// <summary>
        /// Организация, Id
        /// </summary>
        Guid LegalPersonId { get; set; }

        /// <summary>
        /// Организация-покупатель
        /// </summary>
        [RelatedKey(nameof(LegalPersonId))]
        ILegalPerson LegalPerson { get; set; }

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
        /// Комментарий
        /// </summary>
        string Note { get; set; }

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

        /// <summary>
        /// Сумма
        /// </summary>
        decimal? Amount { get; set; }

        /// <summary>
        /// Счет Касса,  Id
        /// </summary>
        Guid? CashAccountId { get; set; }

        /// <summary>
        /// Контрагент, Id
        /// </summary>
        Guid? ContractorId { get; set; }

        /// <summary>
        /// Тип контрагента
        /// </summary>
        CashOrderContractorType ContractorType { get; set; }

        /// <summary>
        /// Счет учета расчетов с контрагентом, Id
        /// </summary>
        Guid? ContractorSettlementAccountId { get; set; }

        /// <summary>
        ///Основание
        /// </summary>
        string Base { get; set; }

        /// <summary>
        ///Приложение 
        /// </summary>
        string Attachment { get; set; }

        /// <summary>
        /// ОРП-основание, Id
        /// </summary>
        Guid? SaleSlipReportId { get; set; }

    }
}
