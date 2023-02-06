using System;
using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces
{
    public interface ISuppliesHeadDocument : IPersistentDocument
    {
        /// <summary>
        /// Id продавца
        /// </summary>
        Guid SellerId { get; set; }

        /// <summary>
        /// ID покупателя
        /// </summary>
        Guid BuyerId { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// № документа
        /// </summary>
        string Number { get; set; }

        /// <summary>
        /// № счета-фактуры
        /// </summary>
        string NumberInvoice { get; set; }

        /// <summary>
        /// Основание договора
        /// </summary>
        Guid? SbaseonId { get; set; }

        /// <summary>
        /// Признак комиссии
        /// </summary>

        bool IsСommission { get; set; }

        IEnumerable<ISuppliesItemDocument> Items { get; }
    }
}
