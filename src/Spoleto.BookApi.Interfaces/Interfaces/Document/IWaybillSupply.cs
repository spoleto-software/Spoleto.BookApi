

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная на поставку
    /// </summary>
    public interface IWaybillSupply : IWaybill
    {
        /// <summary>
        /// Тип накладной на поставку
        /// </summary>
        WaybillSupplyType? WaybillSupplyType { get; set; }
    }
}
