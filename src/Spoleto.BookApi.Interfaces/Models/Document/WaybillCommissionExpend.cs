using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public class WaybillCommissionExpend : WaybillExpendBase, IWaybillCommissionExpend<WaybillItemCommissionExpend>
    {
        /// <summary>
        /// позиции накладной
        /// </summary>
        public List<WaybillItemCommissionExpend> WaybillItems { get; set; }
    }
}
