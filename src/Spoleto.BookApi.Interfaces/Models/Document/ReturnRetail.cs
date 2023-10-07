using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Позиция возврата от розничного покупателя
    /// </summary>
    public class ReturnRetail : PersistentObjectBase, IReturnRetail<ReturnRetailItem>
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
        /// Вид операции возврата
        /// </summary>
        public ReturnType ReturnType { get; set; }

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
        /// Ссылка на связанный орп
        /// </summary>
        public Guid RetailSaleDocumentId { get; set; }

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
        /// Сотрудник, создавший накладную (ответственный), Id
        /// </summary>
        public Guid CreatedEmployeeId { get; set; }


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
        /// Счет учета расчетов с контрагентом, Id
        /// </summary>
        public Guid ContractorSettlementAccountId { get; set; }

        /// <summary>
        /// Счет учета расчетов по авансам, Id
        /// </summary>
        public Guid AdvanceSettlementAccountId { get; set; }

        /// <summary>
        /// Счета учета НДС, Id
        /// </summary>
        public Guid VatAccountId { get; set; }

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
        /// Отразить в книге покупок
        /// </summary>
        public bool PurchaseBook { get; set; }

        /// <summary>
        /// ПокупателемВыставляетсяСчетФактураНаВозврат
        /// </summary>
        public bool ReturnInvoiceFromBuyer { get; set; }

        /// <summary>
        /// ПокупателюВыставляетсяКорректировочныйСчетФактура
        /// </summary>
        public bool CorrectInvoiceToBuyer { get; set; }

        /// <summary>
        /// позиции
        /// </summary>
        public List<ReturnRetailItem> ReturnItems { get; set; }
    }
}
