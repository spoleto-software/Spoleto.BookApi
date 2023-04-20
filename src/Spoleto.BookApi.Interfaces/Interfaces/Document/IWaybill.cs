using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная
    /// </summary>
    public interface IWaybill : IPersistentDocument
    {
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
        /// Счет учета расчетов по авансам, Id
        /// </summary>
        Guid AdvanceSettlementAccountId { get; set; }

        /// <summary>
        /// Грузоотправитель, Id
        /// </summary>
        Guid? ShipperId { get; set; }

        /// <summary>
        /// Грузотправитель
        /// </summary>
        [RelatedKey(nameof(ShipperId))]
        IContractor Shipper { get; set; }

        /// <summary>
        /// Грузополучатель, Id
        /// </summary>
        Guid? ConsigneeId { get; set; }

        /// <summary>
        /// Грузополучатель
        /// </summary>
        [RelatedKey(nameof(ConsigneeId))]
        IContractor Consignee { get; set; }

        /// <summary>
        /// Банковский счет, Id
        /// </summary>
        Guid? BankAccountId { get; set; }

        /// <summary>
        /// Банковский счет
        /// </summary>
        [RelatedKey(nameof(BankAccountId))]
        IBankAccount BankAccount { get; set; }

        /// <summary>
        /// Руководитель, Id
        /// </summary>
        Guid? HeadId { get; set; }

        /// <summary>
        /// Руководитель
        /// </summary>
        [RelatedKey(nameof(HeadId))]
        IEmployee Head { get; set; }

        /// <summary>
        /// Главный бухгалтер, Id
        /// </summary>
        Guid? ChiefAccountantId { get; set; }

        /// <summary>
        /// Главный бухгалтер
        /// </summary>
        [RelatedKey(nameof(ChiefAccountantId))]
        IEmployee ChiefAccountant { get; set; }

        /// <summary>
        /// Ответственное лицо (отпуск груза разрешил), Id
        /// </summary>
        Guid? ResponsiblePersonId { get; set; }

        /// <summary>
        /// Ответственное лицо (отпуск груза разрешил)
        /// </summary>
        [RelatedKey(nameof(ResponsiblePersonId))]
        IEmployee ResponsiblePerson { get; set; }

        /// <summary>
        /// Кладовщик (отпуск груза произвел), Id
        /// </summary>
        Guid? StorekeeperId { get; set; }

        /// <summary>
        /// Кладовщик (отпуск груза произвел)
        /// </summary>
        [RelatedKey(nameof(StorekeeperId))]
        IEmployee Storekeeper { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        string Number { get; set;  }

        /// <summary>
        /// Комментарий
        /// </summary>
        string Note { get; set; }

        /// <summary>
        /// Сумма документа
        /// </summary>
        decimal TotalAmount { get; set; }
    }
}
