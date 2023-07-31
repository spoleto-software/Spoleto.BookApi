using System;
using System.Collections.Generic;
using System.Text;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиции отчета комитенту
    /// </summary>
    public interface ICommitentReportItem : IPersistentObjectBase
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

    }
}
