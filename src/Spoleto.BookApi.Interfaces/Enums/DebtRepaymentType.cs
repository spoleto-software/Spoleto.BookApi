
namespace Spoleto.BookApi.Interfaces
{
    public enum DebtRepaymentType
    {
        /// <summary>
        /// Автоматически
        /// </summary>
        Auto,

        /// <summary>
        /// ПоДокументу
        /// </summary>
        ByDocument,

        /// <summary>
        /// НеПогашать
        /// </summary>
        DontRepay
    }
}
