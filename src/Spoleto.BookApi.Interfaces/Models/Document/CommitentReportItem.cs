using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Позиции отчета комитенту
    /// </summary>
    public class CommitentReportItem : PersistentObjectBase, ICommitentReportItem
    {

        /// <summary>
        /// Номенклатура, Id
        /// </summary>
        public Guid ItemId { get; set; }

        /// <summary>
        /// Номенклатура
        /// </summary>
        [RelatedKey(nameof(ItemId))]
        public Item Item { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Cost { get; set; }

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
        /// Страна, Id
        /// </summary>
        public Guid? CountryId { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        [RelatedKey(nameof(CountryId))]
        public ICountry Country { get; set; }

        /// <summary>
        /// ГТД, Id
        /// </summary>
        public Guid? CargoCustomsDeclarationId { get; set; }

        /// <summary>
        /// ГТД
        /// </summary>
        [RelatedKey(nameof(CargoCustomsDeclarationId))]
        public ICargoCustomsDeclaration CargoCustomsDeclaration { get; set; }
    }
}
