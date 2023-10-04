using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{

    /// <summary>
    /// ОперацияБух (для ручных проводок)
    /// </summary>
    public class AccountingOperation : PersistentObjectBase, IAccountingOperation
     {
        /// <summary>
        /// Организация, Id
        /// </summary>
        public Guid LegalPersonId { get; set; }

        /// <summary>
        /// Организация-покупатель
        /// </summary>
        [RelatedKey(nameof(LegalPersonId))]
        public ILegalPerson LegalPerson { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Сотрудник, создавший накладную (ответственный), Id
        /// </summary>
        public Guid CreatedEmployeeId { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Note { get; set; }
     }
}
