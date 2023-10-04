using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// ОперацияБух (для ручных проводок)
    /// </summary>
    public interface IAccountingOperation : IPersistentDocument
    {
        /// <summary>
        /// Организация, Id
        /// </summary>
        Guid LegalPersonId { get; set; }

        /// <summary>
        /// Организация-покупатель
        /// </summary>
        [RelatedKey(nameof(LegalPersonId))]
        ILegalPerson LegalPerson { get; set; }

        /// <summary>
        /// Сумма
        /// </summary>
        decimal? Amount { get; set; }

        /// <summary>
        /// Сотрудник, создавший накладную (ответственный), Id
        /// </summary>
        Guid CreatedEmployeeId { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        string Note { get; set; }
    }
}
