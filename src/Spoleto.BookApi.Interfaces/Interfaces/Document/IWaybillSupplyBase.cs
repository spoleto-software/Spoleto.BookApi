using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public interface IWaybillSupplyBase : IWaybill
    {
        /// <summary>
        /// Тип накладной на поставку
        /// </summary>
        WaybillSupplyType? WaybillSupplyType { get; set; }
    }
}
