using System;
using Spoleto.BookApi.Interfaces.Models.OperationTicket;

namespace Spoleto.BookApi.Interfaces.OperationTicket
{
    /// <summary>
    /// The ticket for processing object containers.
    /// </summary>
    public interface IOperationTicket : IPersistentObjectBase
    {
        /// <summary>
        /// Gets or sets the status of processing the object container.
        /// </summary>
        OperationTicketStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the start date of processing the object container.
        /// </summary>
        DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end date of processing the object container.
        /// </summary>
        DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the error message (if exists) of processing the object container.
        /// </summary>
        string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the owner identifier of this ticket.
        /// </summary>
        Guid UserId { get; set; }
    }
}