

using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная на поставку
    /// </summary>
    public interface IWaybillSupply<T> : IWaybillSupplyBase
        where T: IWaybillItemSupply
    {
        /// <summary>
        /// позиции накладной
        /// </summary>
        List<T> WaybillItems { get; set; }
    }
}
