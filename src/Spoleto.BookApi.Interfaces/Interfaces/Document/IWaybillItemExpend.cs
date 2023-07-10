using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиции накладной на отгрузку
    /// </summary>
    public interface IWaybillItemExpend : IWaybillItem
    {
       /// <summary>
       /// Счет доходов, Id
       /// </summary>
       Guid IncomeAccountId { get; set; }

       /// <summary>
       /// Счет расходов, Id
       /// </summary>
       Guid ExpenseAccountId { get; set; }

        /// <summary>
        /// Субконто (Номенклатурная группа) Id
        /// </summary>
        Guid? SubcontoNomenclatureGroupId { get; set; }

        /// <summary>
        /// Себестоимость
        /// </summary>
        decimal? SelfCost { get; set; }
    }
}
