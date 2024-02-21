using System;

namespace Spoleto.BookApi.Interfaces.Models.OperationTicket
{
    /// <summary>
    /// Тикеты на обработку контейнеров объектов.
    /// </summary>
    public class OperationTicket
    {
        public Guid Id { get; set; }

        public OperationTicketStatus Status { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string ErrorMessage { get; set; }
    }
}
