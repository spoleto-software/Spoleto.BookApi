using System;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Регистр бухгалтерии - хозрасчетный
    /// </summary>
    public interface ISelfSupportingRegister : IPersistentObjectBase
    {
        /// <summary>
        /// Организация, Id
        /// </summary>
        Guid LegalPersonId { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime? Date { get; set; }

        /// <summary>
        /// Тип регистратора
        /// </summary>
        RegistrarType RegistrarType { get; set; }

        /// <summary>
        /// Регистратор
        /// </summary>
        Guid DocumentId { get; set; }

        /// <summary>
		/// Номер строки
		/// </summary>
        int? LineNumber { get; set; }

        /// <summary>
        /// СчетДт, Id
        /// </summary>
        Guid? AccountDebitId { get; set; }

        /// <summary>
        /// СчетКт, Id
        /// </summary>
        Guid? AccountCreditId { get; set; }

        /// <summary>
        /// ПодразделениеДт, Id
        /// </summary>
        Guid? CompanyDivisionDtId { get; set; }

        /// <summary>
        ///  Подразделение организации Дт
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionDtId))]
        ICompanyDivision CompanyDivisionDt { get; set; }


        /// <summary>
        /// ПодразделениеКт, Id
        /// </summary>
        Guid? CompanyDivisionCtId { get; set; }

        /// <summary>
        /// ПодразделениеКт
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionCtId))]
        ICompanyDivision CompanyDivisionCt { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        decimal? Amount { get; set; }

        /// <summary>
        /// КоличествоДт
        /// </summary>
        decimal? QuantityDt { get; set; }

        /// <summary>
        /// КоличествоКт
        /// </summary>
        decimal? QuantityCt { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        string Note { get; set; }
    }
}
