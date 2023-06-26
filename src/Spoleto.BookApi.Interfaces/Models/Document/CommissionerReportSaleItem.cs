using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Позиция Отчета комиссионера о продажах (проданные товары)
    /// </summary>
    public class CommissionerReportSaleItem : CommissionerReportItem, ICommissionerReportSaleItem
    {
        /// <summary>
        /// Цена передачи
        /// </summary>
        public decimal TransferPrice { get; set; }

        /// <summary>
        /// Сумма передачи
        /// </summary>
        public decimal TransferAmount { get; set; }
    }
}
