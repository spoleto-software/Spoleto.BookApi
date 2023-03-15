using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Отчёт о розничных продажах (ОРП)
    /// </summary>
    public class SaleSlipReport : PersistentObjectBase
    {
        /// <summary>
        /// Коллекция чеков для формирования (ОРП)
        /// </summary>
        public List<SaleSlip> Items { get; set; }
    }
}
