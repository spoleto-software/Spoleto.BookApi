using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиции документа возврата с комиссии
    /// </summary>
    public interface IReturnCommissionItem
    {
        /// <summary>
        /// Ссылка на документ, Id
        /// </summary>
        Guid ReturnCommissionId { get; set; }

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
        /// Количество
        /// </summary>
        decimal Quantity { get; set; }

        /// <summary>
        /// Цена без НДС
        /// </summary>
        decimal PriceWithoutVat { get; set; }

        /// <summary>
        /// Сумма без НДС
        /// </summary>
        decimal AmountWithoutVat { get; set; }

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
        Guid? CountryId { get; set; }

        [RelatedKey(nameof(CountryId))]
        ICountry Country { get; set; }

        /// <summary>
        /// ГТД, Id
        /// </summary>
        Guid? CargoCustomsDeclarationId { get; set; }

        /// <summary>
        /// ГТД
        /// </summary>
        [RelatedKey(nameof(CargoCustomsDeclarationId))]
        ICargoCustomsDeclaration CargoCustomsDeclaration { get; set; }

        /// <summary>
        /// Счет учета, Id
        /// </summary>
        Guid AccountId { get; set; }

        /// <summary>
        /// Счета учета НДС, Id
        /// </summary>
        Guid VatAccountId { get; set; }

        /// <summary>
        /// Счет доходов, Id
        /// </summary>
        Guid IncomeAccountId { get; set; }

        /// <summary>
        /// Счет расходов, Id
        /// </summary>
        Guid ExpenseAccountId { get; set; }

        /// <summary>
        /// Счет учета передачи на комиссию, Id
        /// </summary>
        Guid CommissionAccountId { get; set; }
        /// <summary>
        /// Себестоимость
        /// </summary>
        decimal? SelfCost { get; set; }

    }
}
