using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Возврат товаров поставщику
    /// </summary>
    public interface IReturnSupplier<T> : IPersistentDocument
        where T: IReturnSupplierItem
    {
        /// <summary>
        /// Вид операции
        /// </summary>
        ReturnSupplierType ReturnSupplierType { get; set; }

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
        /// Сотрудник, создавший накладную (ответственный), Id
        /// </summary>
        Guid CreatedEmployeeId { get; set; }


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
        /// Счет учета расчетов с контрагентом, Id
        /// </summary>
        Guid ContractorSettlementAccountId { get; set; }

        /// <summary>
        /// Счет учета расчетов по претензиям, Id
        /// </summary>
        Guid? PretenseSettlementAccountId { get; set; }

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
        /// Корректировочный cчет-фактура получен от поставщика
        /// </summary>
        bool CorrectionInvoiceReceivedFromSupplier { get; set; }

        /// <summary>
        /// Позиции
        /// </summary>
        List<T> ReturnSupplierItems { get; set; }
    }
}
