
namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Тип документа
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// ОРП
        /// </summary>
        RetailSaleDocument,

        /// <summary>
        /// Возврат товаров от покупателя
        /// </summary>
        Return,

        /// <summary>
        /// Накладная на поступление
        /// </summary>
        SupplyWaybill,

        /// <summary>
        /// Накладная на реализацию
        /// </summary>
        ExpendWaybill
    }
}
