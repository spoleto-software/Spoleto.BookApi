using System.Collections.Generic;
using Spoleto.BookApi.Interfaces;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная
    /// </summary>
    public class WaybillSupply : Waybill, IWaybillSupply<WaybillItemSupply>
    {
        /// <summary>
        /// Тип накладной на поставку
        /// </summary>
        public WaybillSupplyType? WaybillSupplyType { get; set; }

        /// <summary>
        /// позиции накладной
        /// </summary>
        public List<WaybillItemSupply> WaybillItems { get; set; }
    }
}
