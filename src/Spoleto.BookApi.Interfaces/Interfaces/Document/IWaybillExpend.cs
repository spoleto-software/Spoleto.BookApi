using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная на отгрузку
    /// </summary>
    public interface IWaybillExpend : IWaybill
    {
        /// <summary>
        /// Тип накладной на отгрузку
        /// </summary>
        WaybillExpendType? WaybillExpendType { get; set; }
    }
}
