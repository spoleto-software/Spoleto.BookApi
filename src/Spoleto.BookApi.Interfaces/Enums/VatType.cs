
namespace Spoleto.BookApi.Interfaces
{
    public enum VatType
    {
        /// <summary>
		/// БезНДС
		/// </summary>
		WithoutVat,

        /// <summary>
        /// Нулевая
        /// </summary>
        Vat0,

        /// <summary>
        /// Общая
        /// </summary>
        General,

        /// <summary>
        /// ОбщаяРасчетная
        /// </summary>
        GeneralEstimated,

        /// <summary>
        /// Пониженная
        /// </summary>
        Lower,

        /// <summary>
        /// ПониженнаяРасчетная
        /// </summary>
        LowerEstimated,
    }
}
