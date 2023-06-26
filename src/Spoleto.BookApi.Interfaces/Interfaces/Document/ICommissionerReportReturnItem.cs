using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиция Отчета комиссионера о продажах (возвращенные товары)
    /// </summary>
    public interface ICommissionerReportReturnItem : ICommissionerReportItem
    {
        /// <summary>
        /// Ссылка на отчет комиссионера, в котором зафиксирована возвращаемая продажа
        /// </summary>
        Guid? SourceCommissionerReportId { get; set; }

        /// <summary>
        /// Возврат по текущему документу
        /// </summary>
        bool IsReturnByCurrentDocument { get; set; }
    }
}
