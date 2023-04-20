
namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Тип накладной на поставку
    /// </summary>
    public enum WaybillSupplyType
    {
        /// <summary>
		/// ВПереработку
		/// </summary>
		Recycling,

        /// <summary>
        /// Оборудование
        /// </summary>
        Stuff,

        /// <summary>
        /// ОбъектыСтроительства
        /// </summary>
        ConstructionProjects,

        /// <summary>
        /// ОсновныеСредства
        /// </summary>
        MainFunds,

        /// <summary>
        /// ПокупкаКомиссия
        /// </summary>
        Commission,

        /// <summary>
        /// ПриобретениеЗемельныхУчастков
        /// </summary>
        LandAcquisition,

        /// <summary>
        /// Товары
        /// </summary>
        Product,

        /// <summary>
        /// Топливо
        /// </summary>
        Fuel,

        /// <summary>
        /// Услуги
        /// </summary>
        Service,

        /// <summary>
        /// УслугиЛизинга
        /// </summary>
        LeasingService,

        /// <summary>
        /// УслугиФакторинга
        /// </summary>
        FactoringService
    }
}
