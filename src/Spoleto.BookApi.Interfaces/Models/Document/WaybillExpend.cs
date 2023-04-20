
namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная на отгрузку
    /// </summary>
    public class WaybillExpend : Waybill, IWaybillExpend
    {
        /// <summary>
        /// Тип накладной на отгрузку
        /// </summary>
        public WaybillExpendType? WaybillExpendType { get; set; }
    }
}
