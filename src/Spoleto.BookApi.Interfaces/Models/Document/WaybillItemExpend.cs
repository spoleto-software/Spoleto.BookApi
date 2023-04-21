using System;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиции накладной на отгрузку
    /// </summary>
    public class WaybillItemExpend : WaybillItem, IWaybillItemExpend
    {
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
        public decimal SelfCost { get; set; }
    }
}
