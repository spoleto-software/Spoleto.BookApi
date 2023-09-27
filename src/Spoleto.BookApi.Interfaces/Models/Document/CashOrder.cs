using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Кассовый ордер
    /// </summary>
    public class CashOrder : PersistentObjectBase, ICashOrder
    {
        /// <summary>
        /// Организация, Id
        /// </summary>
        public Guid LegalPersonId { get; set; }

        /// <summary>
        /// Организация-покупатель
        /// </summary>
        [RelatedKey(nameof(LegalPersonId))]
        public ILegalPerson LegalPerson { get; set; }

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
        /// Комментарий
        /// </summary>
        public string Note { get; set; }

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

        /// <summary>
        /// Сумма
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Счет Касса,  Id
        /// </summary>
        public Guid? CashAccountId { get; set; }

        /// <summary>
        /// Контрагент, Id
        /// </summary>
        public Guid? ContractorId { get; set; }

        /// <summary>
        /// Тип контрагента
        /// </summary>
        public string ContractorType { get; set; }

        /// <summary>
        /// Счет учета расчетов с контрагентом, Id
        /// </summary>
        public Guid? ContractorSettlementAccountId { get; set; }

        /// <summary>
        ///Основание
        /// </summary>
        public string Base { get; set; }

        /// <summary>
        ///Приложение 
        /// </summary>
        public string Attachment { get; set; }

        /// <summary>
        /// ОРП-основание, Id
        /// </summary>
        public Guid? SaleSlipReportId { get; set; }

    }
}
