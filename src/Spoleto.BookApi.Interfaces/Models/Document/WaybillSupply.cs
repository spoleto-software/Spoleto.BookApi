using System.Collections.Generic;
using Spoleto.BookApi.Interfaces;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная
    /// </summary>
    public class WaybillSupply : WaybillSupplyBase, IWaybillSupply<WaybillItemSupply>
    {
        /// <summary>
        /// позиции накладной
        /// </summary>
        public List<WaybillItemSupply> WaybillItems { get; set; }
    }
}
