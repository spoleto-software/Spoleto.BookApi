using System;
using System.Collections.Generic;
using System.Text;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиция Отчета комиссионера о продажах
    /// </summary>
    public interface ICommissionerReportItem
    {

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
        /// Страна, Id
        /// </summary>
        Guid? CountryId { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
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
        /// Счет доходов, Id
        /// </summary>
        Guid IncomeAccountId { get; set; }

        /// <summary>
        /// Счет расходов, Id
        /// </summary>
        Guid ExpenseAccountId { get; set; }

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
