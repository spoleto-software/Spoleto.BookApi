using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{

    /// <summary>
    /// Накладные на поставку (комиссия)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWaybillCommissionSupply<T> : IWaybillSupplyBase
      where T : IWaybillItemCommissionSupply
    {
        /// <summary>
        /// позиции накладной
        /// </summary>
        List<T> WaybillItems { get; set; }
    }
}
