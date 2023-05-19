using System;
using System.Collections.Generic;
using System.Linq;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Чек на продажу
    /// </summary>
    public class SaleSlip : PersistentObjectBase, ISaleSlip<SlipItem, SlipPayment>
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

        ///// <summary>
        ///// Склад
        ///// </summary>
        //public IWarehouse Warehouse { get; set; }

        /// <summary>
        /// Место продажи, Id
        /// </summary>
        public Guid ShopId { get; set; }

        ///// <summary>
        ///// Место продажи
        ///// </summary>
        //public IShop Shop { get; set; }

        /// <summary>
        /// Позиции чека
        /// </summary>
        public List<SlipItem> SlipItems { get; set; }

        /// <summary>
        /// Оплаты в чеке
        /// </summary>
        public List<SlipPayment> SlipPayments { get; set; }

    }
}
