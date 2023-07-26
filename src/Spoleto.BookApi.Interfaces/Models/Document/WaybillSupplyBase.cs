using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{   
    public class WaybillSupplyBase : Waybill
    {
    /// <summary>
    /// Тип накладной на поставку
    /// </summary>
    public WaybillSupplyType? WaybillSupplyType { get; set; }
  
    }
}
