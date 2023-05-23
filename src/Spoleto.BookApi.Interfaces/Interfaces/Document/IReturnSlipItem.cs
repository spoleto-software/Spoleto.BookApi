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
        /// Номер фискального чека (на продажу)
        /// </summary>
        string FiscalSlipNumber { get; set; }

        /// <summary>
        /// Дата реализации
        /// </summary>
        string SaleDate { get; set; }
    }
}
