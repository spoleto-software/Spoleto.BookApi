using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Позиция Отчета комиссионера о продажах (возвращенные товары)
    /// </summary>
    public class CommissionerReportReturnItem : CommissionerReportItem, ICommissionerReportReturnItem
    {
        /// <summary>
        /// Ссылка на отчет комиссионера, в котором зафиксирована возвращаемая продажа
        /// </summary>
        public Guid? SourceCommissionerReportId { get; set; }

        /// <summary>
        /// Возврат по текущему документу
        /// </summary>
        public bool IsReturnByCurrentDocument { get; set; }
    }
}
