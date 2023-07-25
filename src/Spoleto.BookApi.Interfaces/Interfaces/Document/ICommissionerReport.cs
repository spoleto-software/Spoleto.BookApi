using System;
using System.Collections.Generic;
using System.Text;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces
{
      /// <summary>
     /// Отчет комиссионера о продажах
     /// </summary>
    public interface ICommissionerReport<T,V>
        where T : ICommissionerReportSaleItem
        where V : ICommissionerReportReturnItem
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
        CommissionerReportType CommissionerReportType { get; set; }

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
        /// Склад, Id
        /// </summary>
        Guid WarehouseId { get; set; }
      
        /// <summary>
        /// Склад
        /// </summary>
        [RelatedKey(nameof(WarehouseId))]
        IWarehouse Warehouse { get; set; }

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
        /// Счет учета расчетов по авансам полученным, Id
        /// </summary>
        Guid? ReceivedAdvanceSettlementAccountId { get; set; }

        /// <summary>
        /// Счет учета расчетов по авансам выданным, Id
        /// </summary>
        Guid? PaidAdvanceSettlementAccountId { get; set; }

        /// <summary>
        /// Счета учета НДС, Id
        /// </summary>
        Guid? VatAccountId { get; set; }

        /// <summary>
        /// Счета учета расчетов за посреднические услуги, Id
        /// </summary>
        Guid? AgencyServiceAccountId { get; set; }

        /// <summary>
        /// Счет учета затрат, Id
        /// </summary>
        Guid? ExpenseAccountId { get; set; }

        /// <summary>
        /// Субконто (Статьи затрат) Id
        /// </summary>
        Guid? SubcontoExpenseTypeId { get; set; }

        /// <summary>
        ///  Способ Зачета Авансов
        /// </summary>
        AdvanceSettlementType? AdvanceSettlementType { get; set; }

        /// <summary>
        /// Способ Расчета Комиссионного Вознаграждения
        /// </summary>
        CalcCommissionType? CalcCommissionType { get; set; }

        /// <summary>
        ///  Процент Комиссионного Вознаграждения
        /// </summary>
        decimal? PercentCommissionPayment { get; set; }

        /// <summary>
        ///  Удержать Вознаграждение
        /// </summary>
        bool WithholdPayment { get; set; }

        /// <summary>
        /// Проданные товары
        /// </summary>
        List<T> CommissionerReportSaleItems { get; set; }

        /// <summary>
        /// Возвращенные товары
        /// </summary>
        List<V> CommissionerReportReturnItems { get; set; }

    }
}
