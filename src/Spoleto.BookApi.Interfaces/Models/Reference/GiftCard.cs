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

        /// <summary>
        /// Дата добавления
        /// </summary>
        public DateTime? DateAdd { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Ответственный сотрудник, Id
        /// </summary>
        public Guid? CreatedEmployeeId { get; set; }

        /// <summary>
        /// Подразделение организации, Id
        /// </summary>
        public Guid? CompanyDivisionId { get; set; }

        /// <summary>
        ///  Подразделение организации
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionId))]
        public ICompanyDivision CompanyDivision { get; set; }

        /// <summary>
        /// Cчет, Id
        /// </summary>
        public Guid? AccountId { get; set; }
    }
}
