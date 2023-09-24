using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Подарочная карта
    /// </summary>
    public interface IGiftCard : IPaymentTypeContractor
    {
        /// <summary>
        /// Валюта, Id
        /// </summary>
        Guid CurrencyId { get; set; }

        /// <summary>
        /// Валюта
        /// </summary>
        [RelatedKey(nameof(CurrencyId))]
        ICurrency Currency { get; set; }


        /// <summary>
        /// Дата добавления
        /// </summary>
        DateTime? DateAdd { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        string Note { get; set; }

        /// <summary>
        /// Ответственный сотрудник, Id
        /// </summary>
        Guid? CreatedEmployeeId { get; set; }
    }
}
