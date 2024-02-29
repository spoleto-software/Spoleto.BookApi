using System;

namespace Spoleto.BookApi.Interfaces.Models.OperationTicket
{
    /// <summary>
    /// The ticket for processing object containers.
    /// </summary>
    public class OperationTicket
    {
        /// <summary>
        /// The ticket that is not found.
        /// </summary>
        public static readonly OperationTicket NotFound = new OperationTicket { Status = OperationTicketStatus.NoFound };

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public virtual Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets the status of processing the object container.
        /// </summary>
        public OperationTicketStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the start date of processing the object container.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end date of processing the object container.
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the error message (if exists) of processing the object container.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the owner identifier of this ticket.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the owner of this ticket.
        /// </summary>
        public User User { get; set; }
    }
}
