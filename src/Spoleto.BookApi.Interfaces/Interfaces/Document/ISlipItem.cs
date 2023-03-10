using System;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиции чека - товары
    /// </summary>
    public interface ISlipItem : IPersistentDocument
    {

        int LineNumber { get; set; }

        /// <summary>
        /// Номенклатура, Id
        /// </summary>
        Guid ItemId { get; set; }

        /// <summary>
        /// Номенклатура
        /// </summary>
        [RelatedKey(nameof(ItemId))]
        Item Item { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        decimal Quantity { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        decimal Cost { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        decimal Amount { get; set; }

        /// <summary>
        /// Ставка НДС
        /// </summary>
        Vat VatValue { get; set; }

        /// <summary>
        /// Сумма НДС
        /// </summary>
        decimal VatAmount { get; set; }

        /// <summary>
        /// Себестоимость
        /// </summary>
        decimal SelfCost { get; set; }

        /// <summary>
        /// Код маркировки, Id
        /// </summary>
        //public List<Guid> MarkingCodeId { get; set; } TODO: описать в наследнике

    }
}
