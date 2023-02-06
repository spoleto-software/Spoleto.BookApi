namespace Spoleto.BookApi.Interfaces
{

    public enum Vat
    {
        /// <summary>
        /// БезНДС
        /// </summary>
        WithoutVat,
        /// <summary>
        /// НДС0
        /// </summary>
        Vat0,
        /// <summary>
        /// НДС10
        /// </summary>
        Vat10,
        /// <summary>
        /// НДС10_110
        /// </summary>
        Vat10_110,
        /// <summary>
        /// НДС18
        /// </summary>
        Vat18,
        /// <summary>
        /// НДС18_118
        /// </summary>
        Vat18_118,
        /// <summary>
        /// НДС20
        /// </summary>
        Vat20,
        /// <summary>
        /// НДС20_120
        /// </summary>
        Vat20_120
    }
}