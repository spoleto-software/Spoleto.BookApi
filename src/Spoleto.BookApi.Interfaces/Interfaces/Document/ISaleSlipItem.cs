using System;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Позиция чека на продажу
    /// </summary>
    public interface ISaleSlipItem : ISlipItem
    {
        /// <summary>
        /// тип документа оприходования
        /// </summary>
        ReceiptDocumentType? ReceiptDocumentType { get; set; }

        /// <summary>
        /// ссылка на документ оприходования
        /// </summary>
        Guid? ReceiptDocumentId { get; set; }
    }
}
