using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Подарочная карта
    /// </summary>
    public class GiftCard : PaymentTypeContractor, IGiftCard
    {
        /// <summary>
        /// Валюта, Id
        /// </summary>
        public Guid CurrencyId { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        [RelatedKey(nameof(CurrencyId))]
        public ICurrency Currency { get; set; }
    }
}
