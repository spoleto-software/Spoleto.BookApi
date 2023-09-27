
namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Тип контрагента в кассовом ордере
    /// </summary>
    public enum CashOrderContractorType
    {
        /// <summary>
        /// Склад
        /// </summary>
        Warehouse,

        /// <summary>
        /// Контрагент (например, розничный покупатель)
        /// </summary>
        Contractor
    }
}
