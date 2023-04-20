namespace Spoleto.BookApi.Interfaces
{
    public enum DocumentReasonType
    {
        /// <summary>
		/// Прочее
		/// </summary>
		Other,

        /// <summary>
        /// СКомиссионером
        /// </summary>
        WithCommissioner,

        /// <summary>
        /// СКомиссионеромНаЗакупку
        /// </summary>
        WithCommissionerOnPurchase,

        /// <summary>
        /// СКомитентом
        /// </summary>
        WithCommittent,

        /// <summary>
        /// СКомитентомНаЗакупку
        /// </summary>
        WithCommittentOnPurchase,

        /// <summary>
        /// СПокупателем
        /// </summary>
        WithBuyer,

        /// <summary>
        /// СПоставщиком
        /// </summary>
        WithSupplier,

        /// <summary>
        /// СТранспортнойКомпанией
        /// </summary>
        WithTransportCompany,

        /// <summary>
        /// СФакторинговойКомпанией
        /// </summary>
        WithFactoringCompany
    }
}
