using System;
using System.Collections.Generic;
using System.Text;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Позиция чека на возврат
    /// </summary>
    public class ReturnSlipItem : SlipItem, IReturnSlipItem
    {
        /// <summary>
        /// Номер фискального чека
        /// </summary>
        public string FiscalSlipNumber { get; set; }

        /// <summary>
        /// Дата реализации
        /// </summary>
        public DateTime? SaleDate { get; set; }
    }
}
