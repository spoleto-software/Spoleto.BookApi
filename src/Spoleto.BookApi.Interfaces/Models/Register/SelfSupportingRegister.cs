using System;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Регистр бухгалтерии - хозрасчетный
    /// </summary>
    public class SelfSupportingRegister : PersistentObjectBase, ISelfSupportingRegister
    {
        /// <summary>
        /// Организация, Id
        /// </summary>
        public Guid LegalPersonId { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Тип регистратора
        /// </summary>
        public RegistrarType RegistrarType { get; set; }

        /// <summary>
        /// Регистратор
        /// </summary>
        public Guid DocumentId { get; set; }

        /// <summary>
		/// Номер строки
		/// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// СчетДт, Id
        /// </summary>
        public Guid? AccountDebitId { get; set; }

        /// <summary>
        /// СчетКт, Id
        /// </summary>
        public Guid? AccountCreditId { get; set; }

        /// <summary>
        /// ПодразделениеДт, Id
        /// </summary>
        public Guid? CompanyDivisionDtId { get; set; }

        /// <summary>
        ///  Подразделение организации Дт
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionDtId))]
        public ICompanyDivision CompanyDivisionDt { get; set; }


        /// <summary>
        /// ПодразделениеКт, Id
        /// </summary>
        public Guid? CompanyDivisionCtId { get; set; }

        /// <summary>
        /// ПодразделениеКт
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionCtId))]
        public ICompanyDivision CompanyDivisionCt { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// КоличествоДт
        /// </summary>
        public decimal? QuantityDt { get; set; }

        /// <summary>
        /// КоличествоКт
        /// </summary>
        public decimal? QuantityCt { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Note { get; set; }
    }
}
