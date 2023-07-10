using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Отчет комиссионера о продажах
    /// </summary>
    public class CommissionerReport : PersistentObjectBase, ICommissionerReport<CommissionerReportSaleItem, CommissionerReportReturnItem>
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
        public CommissionerReportType CommissionerReportType { get; set; }

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
        /// Склад, Id
        /// </summary>
        public Guid WarehouseId { get; set; }

        /// <summary>
        /// Склад
        /// </summary>
        [RelatedKey(nameof(WarehouseId))]
        public IWarehouse Warehouse { get; set; }

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
        /// Счет учета расчетов по авансам полученным, Id
        /// </summary>
        public Guid? ReceivedAdvanceSettlementAccountId { get; set; }

        /// <summary>
        /// Счет учета расчетов по авансам выданным, Id
        /// </summary>
        public Guid? PaidAdvanceSettlementAccountId { get; set; }

        /// <summary>
        /// Счета учета НДС, Id
        /// </summary>
        public Guid? VatAccountId { get; set; }

        /// <summary>
        /// Счета учета расчетов за посреднические услуги, Id
        /// </summary>
        public Guid? AgencyServiceAccountId { get; set; }

        /// <summary>
        /// Счет учета затрат, Id
        /// </summary>
        public Guid? ExpenseAccountId { get; set; }

        /// <summary>
        /// Субконто (Статьи затрат) Id
        /// </summary>
         public Guid? SubcontoExpenseTypeId { get; set; }

        /// <summary>
        /// Проданные товары
        /// </summary>
        public List<CommissionerReportSaleItem> CommissionerReportSaleItems { get; set; }

        /// <summary>
        /// Возвращенные товары
        /// </summary>
        public List<CommissionerReportReturnItem> CommissionerReportReturnItems { get; set; }
    }
}
