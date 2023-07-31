using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Отчет комитенту
    /// </summary>
    public interface ICommitentReport<T> : IPersistentDocument
          where T : ICommitentReportItem
    {
        /// <summary>
        /// Номер
        /// </summary>
        string Number { get; set; }

        /// <summary>
        /// Дата отчета
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Вид Операции
        /// </summary>
        CommitentReportType CommitentReportType { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        Guid LegalPersonId { get; set; }


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
        /// Контрагент, Id
        /// </summary>
        Guid ContractorId { get; set; }

        /// <summary>
        /// Контрагент
        /// </summary>
        [RelatedKey(nameof(Contractor))]
        IContractor Contractor { get; set; }


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
        /// Валюта, Id
        /// </summary>
        Guid CurrencyId { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        [RelatedKey(nameof(CurrencyId))]
        ICurrency Currency { get; set; }

        /// <summary>
        /// Сотрудник, создавший накладную (ответственный), Id
        /// </summary>
        Guid CreatedEmployeeId { get; set; }

        /// <summary>
        /// Счет учета расчетов с контрагентом, Id
        /// </summary>
        Guid? ContractorSettlementAccountId { get; set; }

        /// <summary>
        /// Счет учета расчетов по авансам, Id
        /// </summary>
        Guid? AdvanceSettlementAccountId { get; set; }

        /// <summary>
        /// Счета учета НДС, Id
        /// </summary>
        Guid? VatAccountId { get; set; }

        /// <summary>
        /// Счет учета доходов, Id
        /// </summary>
        Guid? IncomeAccountId { get; set; }


        /// <summary>
        /// Субконто (Номенклатурная группа) Id
        /// </summary>
        Guid? SubcontoNomenclatureGroupId { get; set; }

        /// <summary>
        /// Способ Расчета Комиссионного Вознаграждения
        /// </summary>
        CalcCommissionType? CalcCommissionType { get; set; }

        /// <summary>
        ///  Удержать Вознаграждение
        /// </summary>
        bool WithholdPayment { get; set; }

        /// <summary>
        /// Ставка НДС вознаграждения
        /// </summary>
        Vat VatReward { get; set; }

        /// <summary>
        /// Товары
        /// </summary>
        List<T> CommitentReportItems { get; set; }

    }
}
