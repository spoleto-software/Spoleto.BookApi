

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Тип регистратора (документа, на основании которого создается проводка)
    /// </summary>
    public enum RegistrarType
    {
        /// <summary>
        /// ОперацияБух
        /// </summary>
        AccountingOperation,

        /// <summary>
        /// ОРП
        /// </summary>
        RetailSaleDocument
    }
}
