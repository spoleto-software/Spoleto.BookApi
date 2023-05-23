using System;
using System.Collections.Generic;
using System.Text;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Оплата в чеке на продажу
    /// </summary>
    public class SaleSlipPayment : SlipPayment, ISaleSlipPayment
    {

    }
}
