using System;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Подарочная карта в чеке (покупка и возврат подарочной карты)
    /// </summary>
    public interface ISlipGiftCard : IPersistentDocument
    {
        /// <summary>
        /// Номер строки
        /// </summary>
        int LineNumber { get; set; }


        /// <summary>
        /// Подарочная карта, Id
        /// </summary>
        Guid GiftCardId { get; set; }


        /// <summary>
        /// Подарочная карта
        /// </summary>
        [RelatedKey(nameof(GiftCardId))]
        GiftCard GiftCard { get; set; }


        /// <summary>
        /// Цена
        /// </summary>
        decimal Cost { get; set; }
    }
}
