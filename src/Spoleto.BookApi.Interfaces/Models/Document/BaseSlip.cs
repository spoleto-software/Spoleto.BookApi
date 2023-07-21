using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Базовый чек
    /// </summary>
    public class BaseSlip : PersistentObjectBase, IBaseSlip
    {
        /// <summary>
        /// Дата чека
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        public Guid LegalPersonId { get; set; }

        /// <summary>
        /// Склад, Id
        /// </summary>
        public Guid WarehouseId { get; set; }

        /// <summary>
        /// Склад
        /// </summary>
        [RelatedKey(nameof(WarehouseId))]
        public IWarehouse Warehouse { get; set; }

        /// <summary>
        /// Место продажи, Id
        /// </summary>
        public Guid ShopId { get; set; }

        /// <summary>
        /// Место продажи
        /// </summary>
        [RelatedKey(nameof(ShopId))]
        public IShop Shop { get; set; }

        /// <summary>
        /// ОРП, Id (если не указан, будет создан автоматически)
        /// </summary>
        public Guid SaleSlipReportId { get; set; }

    }
}
