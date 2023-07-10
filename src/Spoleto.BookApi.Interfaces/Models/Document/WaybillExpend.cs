
using System;
using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная на отгрузку
    /// </summary>
    public class WaybillExpend : WaybillExpendBase, IWaybillExpend<WaybillItemExpend>
    {
        /// <summary>
        /// Субконто (Номенклатурная группа) Id
        /// </summary>
        public Guid? SubcontoNomenclatureGroupId { get; set; }

        /// <summary>
        /// позиции накладной
        /// </summary>
        public List<WaybillItemExpend> WaybillItems { get; set; }

    }
}
