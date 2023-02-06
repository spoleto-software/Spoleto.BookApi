using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Чек на продажу
    /// </summary>
    public class SaleSlip : PersistentObjectBase, ISaleSlip
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
        public IEnumerable<SlipItem> SlipItems { get; set; }

        /// <summary>
        /// Оплаты в чеке
        /// </summary>
        public IEnumerable<SlipPayment> SlipPayments { get; set; }


        /// <summary>
        /// Позиции чека
        /// </summary>
        IEnumerable<ISlipItem> ISaleSlip.SlipItems
        {
            get { return SlipItems.Cast<ISlipItem>(); }
            set { }
        }

        /// <summary>
        /// Оплаты в чеке
        /// </summary>
        IEnumerable<ISlipPayment> ISaleSlip.SlipPayments
        {
            get { return SlipPayments.Cast<ISlipPayment>(); }
            set { }
        }
    }
}
