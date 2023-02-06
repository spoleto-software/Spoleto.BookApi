using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{

    /// <summary>
    /// Банковский счет
    /// </summary>
    public interface IBankAccount : IPersistentReference
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
		/// Владелец
		/// </summary>
        public string Owner { get; set; }
      
        /// <summary>
        /// Номер Счета
        /// </summary>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Валютный
        /// </summary>
        public bool? IsForeignExchange { get; set; }

        /// <summary>
        /// Дата Открытия
        /// </summary>
        public DateTime? DateOpen { get; set; }

        /// <summary>
        /// Дата Закрытия
        /// </summary>
        public DateTime? DateClose { get; set; }

        /// <summary>
        /// Вид счета
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Счет корпоративных расчетов
        /// </summary>
        public bool? IsCorporateAccount  { get; set; }


        /// <summary>
        /// Подразделение, Id
        /// </summary>
        public Guid CompanyDivisionId { get; set; }

        /// <summary>
        /// Подразделение организации
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionId))]
        public ICompanyDivision CompanyDivision { get; set; }

        /// <summary>
        /// Банк, Id
        /// </summary>
        public Guid BankId { get; set; }

        /// <summary>
        /// Банк
        /// </summary>
        [RelatedKey(nameof(BankId))]
        public IBank Bank { get; set; }

        /// <summary>
        /// Банк для расчетов, Id
        /// </summary>
        public Guid BankForCalculationId { get; set; }

        /// <summary>
        /// Банк Для Расчетов
        /// </summary>
        [RelatedKey(nameof(BankForCalculationId))]
        public IBank BankForCalculation  { get; set; }

    }
}
