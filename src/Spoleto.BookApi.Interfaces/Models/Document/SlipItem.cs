using System;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Позиция чека
    /// </summary>
    public class SlipItem : PersistentObjectBase, ISlipItem
    {
        public int LineNumber { get; set; }

        public Guid ItemId { get; set; }

        /// <summary>
        /// Номенклатура
        /// </summary>
        public Item Item { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Ставка НДС
        /// </summary>
        public Vat VatValue { get; set; }

        /// <summary>
        /// Сумма НДС
        /// </summary>
        public decimal VatAmount { get; set; }

        /// <summary>
        /// Себестоимость
        /// </summary>
        public decimal SelfCost { get; set; }
    }
}
