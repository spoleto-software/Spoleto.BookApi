using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Счет-Фактура
    /// </summary>
    public interface ISupplyInvoice : IPersistentDocument
    {
        /// <summary>
        /// Номер
        /// </summary>
        string Number { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Номер связанной накладной
        /// </summary>
        string WaybillNumber { get; set; }

        /// <summary>
        /// Дата связанной накладной
        /// </summary>
        DateTime WaybillDate { get; set; }


        /// <summary>
        /// Организация, Id
        /// </summary>
        Guid LegalPersonId { get; set; }

        /// <summary>
        /// Контрагент, Id
        /// </summary>
        Guid ContractorId { get; set; }

        /// <summary>
        /// Договор с контрагентом, Id
        /// </summary>
        Guid? DocumentReasonId { get; set; }

        /// <summary>
        /// Валюта, Id
        /// </summary>
        Guid CurrencyId { get; set; }

        /// <summary>
        /// Ответственное лицо, Id
        /// </summary>
        Guid CreatedEmployeeId { get; set; }

        /// <summary>
        /// Сумма документа
        /// </summary>
        decimal TotalAmount { get; set; }

        /// <summary>
        /// Сумма НДС
        /// </summary>
        decimal VatAmount { get; set;  }

        /// <summary>
        /// Связанные накладные на поставку
        /// </summary>
        List<WaybillSupply> SupplyWaybills { get; set; }

    }
}
