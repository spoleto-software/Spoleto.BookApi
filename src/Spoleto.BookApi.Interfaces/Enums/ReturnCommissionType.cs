
namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Вид операции возврат с комиссии
    /// </summary>
    public enum ReturnCommissionType
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
