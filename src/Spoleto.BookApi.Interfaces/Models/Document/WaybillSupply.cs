using Spoleto.BookApi.Interfaces;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная
    /// </summary>
    public class WaybillSupply : Waybill, IWaybillSupply
    {
        /// <summary>
        /// Тип накладной на поставку
        /// </summary>
        public WaybillSupplyType? WaybillSupplyType { get; set; }
    }
}
