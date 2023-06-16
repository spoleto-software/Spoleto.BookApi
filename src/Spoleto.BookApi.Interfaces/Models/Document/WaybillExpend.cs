
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
        /// позиции накладной
        /// </summary>
        public List<WaybillItemExpend> WaybillItems { get; set; }

    }
}
