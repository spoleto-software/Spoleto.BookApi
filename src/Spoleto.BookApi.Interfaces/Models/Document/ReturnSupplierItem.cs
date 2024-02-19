using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// ПОзиция возврата поставщику
    /// </summary>
    public class ReturnSupplierItem : PersistentObjectBase, IReturnSupplierItem
    {
        /// <summary>
        /// Возврат поставщику, Id
        /// </summary>
        public Guid ReturnSupplierId { get; set; }

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
        public Guid? UnitId { get; set; }

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
        /// Цена без НДС
        /// </summary>
        public decimal PriceWithoutVat { get; set; }

        /// <summary>
        /// Сумма без НДС
        /// </summary>
        public decimal AmountWithoutVat { get; set; }

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
        public Guid? CountryId { get; set; }

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

        /// <summary>
        /// Счет учета, Id
        /// </summary>
        public Guid AccountId { get; set; }

        /// <summary>
        /// Счета учета НДС, Id
        /// </summary>
        public Guid VatAccountId { get; set; }

        /// <summary>
        /// тип документа оприходования
        /// </summary>
        public ReceiptDocumentType? ReceiptDocumentType { get; set; }

        /// <summary>
        /// ссылка на документ оприходования
        /// </summary>
        public Guid? ReceiptDocumentId { get; set; }
    }
}
