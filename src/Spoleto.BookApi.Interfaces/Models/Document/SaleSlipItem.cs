using System;
using System.Collections.Generic;
using System.Text;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Позиция чека на продажу
    /// </summary>
    public class SaleSlipItem : SlipItem, ISaleSlipItem
    {
    }
}
