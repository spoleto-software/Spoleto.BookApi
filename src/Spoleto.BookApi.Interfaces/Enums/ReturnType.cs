
namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Вид операции возврата
    /// </summary>
    public enum ReturnType
    {
        /// <summary>
        /// Оборудование
        /// </summary>
        Stuff,

        /// <summary>
        /// ОтгруженныеТовары
        /// </summary>
        ShippedGood,

        /// <summary>
        /// Товары
        /// </summary>
        Good,

        /// <summary>
        /// ПереданныеТовары
        /// </summary>
        TransferGood,

        /// <summary>
        /// ВыкупленныеКомиссионеромТовары
        /// </summary>
        BoughtCommissionGood
    }
}
