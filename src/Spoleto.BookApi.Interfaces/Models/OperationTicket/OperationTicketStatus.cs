namespace Spoleto.BookApi.Interfaces.Models.OperationTicket
{
    /// <summary>
    /// Статусы тикетов обработки контейнеров объектов.
    /// </summary>
    public enum OperationTicketStatus
    {
        NoFound,

        InProgress,

        Completed,

        Failed
    }
}
