using System;

namespace Spoleto.BookApi.Interfaces.Models.OperationTicket
{
    /// <summary>
    /// Тикеты на обработку контейнеров объектов.
    /// </summary>
    public class OperationTicket
    {
        /// <summary>
        /// A ticket that is not found.
        /// </summary>
        public static readonly OperationTicket NotFound = new OperationTicket { Status = OperationTicketStatus.NoFound };

        public Guid Id { get; set; }

        public OperationTicketStatus Status { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string ErrorMessage { get; set; }
    }
}
