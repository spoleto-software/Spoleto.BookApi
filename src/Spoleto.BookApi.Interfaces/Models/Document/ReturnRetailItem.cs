﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class ReturnRetailItem : PersistentObjectBase, IReturnRetailItem
    {
        /// <summary>
        /// Ссылка на документ, Id
        /// </summary>
        public Guid ReturnRetailId { get; set; }

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
        /// Счет доходов, Id
        /// </summary>
        public Guid IncomeAccountId { get; set; }

        /// <summary>
        /// Счет расходов, Id
        /// </summary>
        public Guid ExpenseAccountId { get; set; }

        /// <summary>
        /// Себестоимость
        /// </summary>
        public decimal? SelfCost { get; set; }

        /// <summary>
        /// Субконто номенклатурной группы, Id
        /// </summary>
        public Guid SubcontoNomenclatureGroupId { get; set; }

        /// <summary>
        /// Способ учета НДС
        /// </summary>
        public VatAccountingType VatAccountingType { get; set; }
    }
}
