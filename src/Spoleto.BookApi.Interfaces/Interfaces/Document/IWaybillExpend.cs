using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная на отгрузку
    /// </summary>
    public interface IWaybillExpend<T> : IWaybillExpendBase 
        where T: IWaybillItemExpend
    {

        /// <summary>
        /// позиции накладной
        /// </summary>
        List<T> WaybillItems { get; set; }
    }
}
