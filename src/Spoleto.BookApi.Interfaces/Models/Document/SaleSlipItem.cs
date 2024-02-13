using System;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Позиция чека на продажу
    /// </summary>
    public class SaleSlipItem : SlipItem, ISaleSlipItem
    {
        /// <summary>
        /// тип документа оприходования
        /// </summary>
       public ReceiptDocumentType? ReceiptDocumentType { get; set; }

        /// <summary>
        /// ссылка на документ оприходования
        /// </summary>
        public Guid? ReceiptDocumentId { get; set; }
    }
}
