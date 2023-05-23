using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Оплата в чеке на возврат
    /// </summary>
    public class ReturnSlipPayment : SlipPayment, IReturnSlipPayment
    {
    }
}
