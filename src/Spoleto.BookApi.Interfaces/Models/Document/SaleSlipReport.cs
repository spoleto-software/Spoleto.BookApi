using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Отчёт о розничных продажах (ОРП)
    /// </summary>
    public class SaleSlipReport : PersistentObjectBase
    {
        /// <summary>
        /// Коллекция чеков на продажу для формирования ОРП
        /// </summary>
        public List<SaleSlip> SaleItems { get; set; }

        /// <summary>
        /// Коллекция чеков на возврат для формирования ОРП
        /// </summary>
        public List<ReturnSlip> ReturnItems { get; set; }
    }
}
