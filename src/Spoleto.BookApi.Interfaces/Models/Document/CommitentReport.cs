using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Отчет комитенту
    /// </summary>
    public class CommitentReport : PersistentObjectBase, ICommitentReport<CommitentReportItem>
    {
        /// <summary>
        /// Номер
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Дата отчета
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Вид Операции
        /// </summary>
        public CommitentReportType CommitentReportType { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        public Guid LegalPersonId { get; set; }


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
        /// Контрагент, Id
        /// </summary>
        public Guid ContractorId { get; set; }

        /// <summary>
        /// Контрагент
        /// </summary>
        [RelatedKey(nameof(Contractor))]
        public IContractor Contractor { get; set; }


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
        /// Валюта, Id
        /// </summary>
        public Guid CurrencyId { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        [RelatedKey(nameof(CurrencyId))]
        public ICurrency Currency { get; set; }

        /// <summary>
        /// Сотрудник, создавший накладную (ответственный), Id
        /// </summary>
        public Guid CreatedEmployeeId { get; set; }

        /// <summary>
        /// Счет учета расчетов с контрагентом, Id
        /// </summary>
        public Guid? ContractorSettlementAccountId { get; set; }

        /// <summary>
        /// Счет учета расчетов по авансам, Id
        /// </summary>
        public Guid? AdvanceSettlementAccountId { get; set; }

        /// <summary>
        /// Счета учета НДС, Id
        /// </summary>
        public Guid? VatAccountId { get; set; }

        /// <summary>
        /// Счет учета доходов, Id
        /// </summary>
        public Guid? IncomeAccountId { get; set; }


        /// <summary>
        /// Субконто (Номенклатурная группа) Id
        /// </summary>
        public Guid? SubcontoNomenclatureGroupId { get; set; }

        /// <summary>
        /// Способ Расчета Комиссионного Вознаграждения
        /// </summary>
        public CalcCommissionType? CalcCommissionType { get; set; }

        /// <summary>
        ///  Удержать Вознаграждение
        /// </summary>
        public bool WithholdPayment { get; set; }

        /// <summary>
        /// Товары
        /// </summary>
        public List<CommitentReportItem> CommitentReportItems { get; set; }
    }
}
