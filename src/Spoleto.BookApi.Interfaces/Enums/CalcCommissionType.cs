
namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
	/// СпособыРасчетаКомиссионногоВознаграждения
	/// </summary>
    public enum CalcCommissionType
    {
        /// <summary>
        /// НеРассчитывается
        /// </summary>
        Ignore,
        /// <summary>
        /// ПроцентОтРазностиСуммПродажиИПоступления
        /// </summary>
        PercentOfDiffSalesReceipts,
        /// <summary>
        /// ПроцентОтСуммыПродажи
        /// </summary>
        PercentOfSaleAmount
    }
}
