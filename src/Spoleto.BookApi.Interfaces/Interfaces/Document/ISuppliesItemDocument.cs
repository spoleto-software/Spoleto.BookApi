using System;

namespace Spoleto.BookApi.Interfaces
{
    public interface ISuppliesItemDocument : IPersistentDocument
    {
        /// <summary>
        /// ID модели
        /// </summary>
        Guid ModelId { get; set; }

        /// <summary>
        /// ID ГТД
        /// </summary>
        Guid? GtdId { get; set; }

        /// <summary>
        /// ID страны
        /// </summary>
        Guid? CountryId { get; set; }
        
        /// <summary>
        /// Кол-во
        /// </summary>
        int Count { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// Id НДС
        /// </summary>
        Guid VatValueId { get; set; }

        /// <summary>
        /// НДС за позицию
        /// </summary>
        decimal VatAmount { get; set; }

        /// <summary>
        /// Сумма НДС
        /// </summary>
        decimal SumVatAmount { get; set; }

        /// <summary>
        /// Принадлежность к товару
        /// </summary>
        bool IsGood { get; set; }

        /// <summary>
        /// Сумма по строке
        /// </summary>
        decimal SumPos { get; set; }

        /// <summary>
        /// Признак комиссии
        /// </summary>
        bool IsСommission { get; set; }
    }
}
