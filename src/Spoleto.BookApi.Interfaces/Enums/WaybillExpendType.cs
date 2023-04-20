
namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Тип накладной на отгрузку
    /// </summary>
    public enum WaybillExpendType
    {
        /// <summary>
		/// Оборудование
		/// </summary>
		Stuff,

        /// <summary>
        /// ОтгрузкаБезПереходаПраваСобственности
        /// </summary>
        WithoutChangeOwnership,

        /// <summary>
        /// ПродажаКомиссия
        /// </summary>
        Commission,

        /// <summary>
        /// Товары
        /// </summary>
        Good,

        /// <summary>
        /// Услуги
        /// </summary>
        Service,
    }
}
