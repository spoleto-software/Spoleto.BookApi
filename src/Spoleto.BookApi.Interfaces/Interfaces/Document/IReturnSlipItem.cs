using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиция чека на возврат
    /// </summary>
    public interface IReturnSlipItem : ISlipItem
    {
        /// <summary>
        /// Номер фискального чека
        /// </summary>
        string FiscalSlipNumber { get; set; }

        /// <summary>
        /// Дата реализации
        /// </summary>
        DateTime? SaleDate { get; set; }
    }
}
