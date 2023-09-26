using System;
using System.Collections.Generic;
using System.Text;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class SlipGiftCard : PersistentObjectBase, ISlipGiftCard
    {
        /// <summary>
        /// Номер строки
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// Подарочная карта, Id
        /// </summary>
        public Guid GiftCardId { get; set; }

        /// <summary>
        /// Подарочная карта
        /// </summary>
        [RelatedKey(nameof(GiftCardId))]
        public GiftCard GiftCard { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Cost { get; set; }
    }
}
