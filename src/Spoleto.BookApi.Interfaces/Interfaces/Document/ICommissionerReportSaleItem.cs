using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиция Отчета комиссионера о продажах (проданные товары)
    /// </summary>
    public interface ICommissionerReportSaleItem : ICommissionerReportItem
    {
        /// <summary>
        /// Цена передачи
        /// </summary>
        decimal TransferPrice { get; set; }

        /// <summary>
        /// Сумма передачи
        /// </summary>
        decimal TransferAmount { get; set; }

    }
}
