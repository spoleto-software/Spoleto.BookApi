using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{ 
    public interface IWaybillCommissionExpend<T> : IWaybillExpendBase
    where T: IWaybillItemCommissionExpend
    {
        /// <summary>
        /// позиции накладной
        /// </summary>
        List<T> WaybillItems { get; set; }
    }
}
