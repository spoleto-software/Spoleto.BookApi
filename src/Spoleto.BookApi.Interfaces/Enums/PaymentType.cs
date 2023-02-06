namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Виды оплат
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        /// БанковскийКредит
        /// </summary>
        Credit,
        /// <summary>
        /// Наличные
        /// </summary>
        Cash,
        /// <summary>
        /// ПлатежнаяКарта
        /// </summary>
        BankCard,
        /// <summary>
        /// ПодарочныйСертификатСобственный
        /// </summary>
        GiftCertificateOwn,
        /// <summary>
        /// ПодарочныйСертификатСторонний
        /// </summary>
        GiftCertificateForeign,
    }

}