using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public enum CommissionerReportType
    {
        /// <summary>
        /// Розничные продажи
        /// </summary>
        Retail,

        /// <summary>
        /// Оптовые продажи
        /// </summary>
        Wholesale,

        /// <summary>
        /// Списание
        /// </summary>
        WriteOff
    }
}
