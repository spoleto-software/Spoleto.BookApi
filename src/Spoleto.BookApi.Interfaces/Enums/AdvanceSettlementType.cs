
namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    ///  СпособыЗачетаАвансов
    /// </summary>
    public enum AdvanceSettlementType
    {
        /// <summary>
		/// Автоматически
		/// </summary>
		Auto,
        /// <summary>
        /// Не Зачитывать
        /// </summary>
        Ignore,
        /// <summary>
        /// ПоДокументу
        /// </summary>
        ByDocument,
    }
}
