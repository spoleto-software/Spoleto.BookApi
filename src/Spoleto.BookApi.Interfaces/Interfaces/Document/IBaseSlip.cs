using System;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Чек на продажу
    /// </summary>
    public interface IBaseSlip : IPersistentDocument
    {
        /// <summary>
        /// Дата чека
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        Guid LegalPersonId { get; set; }

        /// <summary>
        /// Склад, Id
        /// </summary>
        Guid WarehouseId { get; set; }

        /// <summary>
        /// Склад
        /// </summary>
        [RelatedKey(nameof(WarehouseId))]
        IWarehouse Warehouse { get; set; }

        /// <summary>
        /// Магазин, Id
        /// </summary>
        Guid ShopId { get; set; }

        /// <summary>
        /// Место продажи
        /// </summary>
        [RelatedKey(nameof(ShopId))]
        IShop Shop { get; set; }

        /// <summary>
        /// ОРП, Id (если не указан, будет создан автоматически)
        /// </summary>
        Guid? SaleSlipReportId { get; set; }

    }
}
