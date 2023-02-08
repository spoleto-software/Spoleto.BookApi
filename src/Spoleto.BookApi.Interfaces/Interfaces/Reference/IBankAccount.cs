using System;

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
        string Name { get; set; }

        /// <summary>
		/// Владелец
		/// </summary>
        string Owner { get; set; }

        /// <summary>
        /// Номер Счета
        /// </summary>
        string AccountNumber { get; set; }

        /// <summary>
        /// Валютный
        /// </summary>
        bool? IsForeignExchange { get; set; }

        /// <summary>
        /// Дата Открытия
        /// </summary>
        DateTime? DateOpen { get; set; }

        /// <summary>
        /// Дата Закрытия
        /// </summary>
        DateTime? DateClose { get; set; }

        /// <summary>
        /// Вид счета
        /// </summary>
        string AccountType { get; set; }

        /// <summary>
        /// Счет корпоративных расчетов
        /// </summary>
        bool? IsCorporateAccount { get; set; }


        /// <summary>
        /// Подразделение, Id
        /// </summary>
        Guid CompanyDivisionId { get; set; }

        /// <summary>
        /// Подразделение организации
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionId))]
        ICompanyDivision CompanyDivision { get; set; }

        /// <summary>
        /// Банк, Id
        /// </summary>
        Guid BankId { get; set; }

        /// <summary>
        /// Банк
        /// </summary>
        [RelatedKey(nameof(BankId))]
        IBank Bank { get; set; }

        /// <summary>
        /// Банк для расчетов, Id
        /// </summary>
        Guid BankForCalculationId { get; set; }

        /// <summary>
        /// Банк Для Расчетов
        /// </summary>
        [RelatedKey(nameof(BankForCalculationId))]
        IBank BankForCalculation { get; set; }

    }
}
