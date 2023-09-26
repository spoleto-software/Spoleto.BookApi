using System;
using System.Collections.Generic;
using System.Linq;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Чек на продажу
    /// </summary>
    public class SaleSlip : BaseSlip, ISaleSlip<SaleSlipItem, SaleSlipPayment, SaleSlipGiftCard>
    {
       
        /// <summary>
        /// Позиции чека
        /// </summary>
        public List<SaleSlipItem> SlipItems { get; set; }

        /// <summary>
        /// Проданные подарочные сертификаты
        /// </summary>
        public List<SaleSlipGiftCard> SlipGiftCards { get; set; }

        /// <summary>
        /// Оплаты в чеке
        /// </summary>
        public List<SaleSlipPayment> SlipPayments { get; set; }

    }
}
