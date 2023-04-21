

using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная на поставку
    /// </summary>
    public interface IWaybillSupply<T> : IWaybill
        where T: IWaybillItemSupply
    {
        /// <summary>
        /// Тип накладной на поставку
        /// </summary>
        WaybillSupplyType? WaybillSupplyType { get; set; }

        /// <summary>
        /// позиции накладной
        /// </summary>
        List<T> WaybillItems { get; set; }
    }
}
