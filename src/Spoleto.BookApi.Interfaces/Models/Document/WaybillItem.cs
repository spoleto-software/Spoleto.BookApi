using System;
using System.Collections.Generic;
using System.Text;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиция накладной
    /// </summary>
    public class WaybillItem : PersistentObjectBase, IWaybillItem
    {
        /// <summary>
        /// Номенклатура, Id
        /// </summary>
        public Guid ItemId { get; set; }

        /// <summary>
        /// Номенклатура
        /// </summary>
        [RelatedKey(nameof(ItemId))]
        public IItem Item { get; set; }

        /// <summary>
        /// Единица измерения, Id
        /// </summary>
        public Guid UnitId { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [RelatedKey(nameof(UnitId))]
        public IUnit Unit { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Цена 
        /// </summary>
        public decimal Price { get; set; }

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
        /// Страна происхождения, Id
        /// </summary>
        public Guid CountryId { get; set; }

        [RelatedKey(nameof(CountryId))]
        public ICountry Country { get; set; }

        /// <summary>
        /// ГТД, Id
        /// </summary>
        public Guid GtdId { get; set; }

        /// <summary>
        /// ГТД
        /// </summary>
        [RelatedKey(nameof(GtdId))]
        public ICargoCustomsDeclaration Gtd { get; set; }

        /// <summary>
        /// Счет учета, Id
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// Счета учета НДС, Id
        /// </summary>
        public Guid VatAccountId { get; set; }
    }
}
