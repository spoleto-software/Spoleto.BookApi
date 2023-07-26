using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Накладные на поставку (комиссия)
    /// </summary>
    public class WaybillCommissionSupply : WaybillSupplyBase, IWaybillCommissionSupply<WaybillItemCommissionSupply>
    {
        /// <summary>
        /// позиции накладной
        /// </summary>
        public List<WaybillItemCommissionSupply> WaybillItems { get; set; }
    }
}
