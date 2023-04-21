using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиция накладной
    /// </summary>
    public interface IWaybillItem : IPersistentDocument
    {
        /// <summary>
        /// Номенклатура, Id
        /// </summary>
        Guid ItemId { get; set; }

        /// <summary>
        /// Номенклатура
        /// </summary>
        [RelatedKey(nameof(ItemId))]
        IItem Item { get; set; }

        /// <summary>
        /// Единица измерения, Id
        /// </summary>
        Guid UnitId { get; set; }

        /// <summary>
        /// Единица измерения
        /// </summary>
        [RelatedKey(nameof(UnitId))]
        IUnit Unit { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        decimal Quantity { get; set; }  

        /// <summary>
        /// Цена 
        /// </summary>
        decimal Price { get; set; }

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
        /// Страна происхождения, Id
        /// </summary>
        Guid  CountryId { get; set; }

        [RelatedKey(nameof(CountryId))]
        ICountry Country { get; set; }

        /// <summary>
        /// ГТД, Id
        /// </summary>
        Guid GtdId { get; set; }

        /// <summary>
        /// ГТД
        /// </summary>
        [RelatedKey(nameof(GtdId))]
        ICargoCustomsDeclaration Gtd { get; set; }

        /// <summary>
        /// Счет учета, Id
        /// </summary>
        Guid AccountId { get; set; }

        /// <summary>
        /// Счета учета НДС, Id
        /// </summary>
        Guid VatAccountId { get; set; }

    }
}
