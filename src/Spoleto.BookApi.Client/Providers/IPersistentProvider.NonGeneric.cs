using System;
using System.Threading.Tasks;
using Spoleto.BookApi.Interfaces.Models;
using Spoleto.BookApi.Interfaces.Models.OperationTicket;

namespace Spoleto.BookApi.Client.Providers
{
    public partial interface IPersistentProvider
    {
        /// <summary>
        /// Inserts the objects from the container into the data source.
        /// </summary>
        /// <returns>The operation ticket identifier.</returns>
        Guid CreateContainer(PersistentProviderOption settings, string dataBaseName, bool confirm, PersistentContainer container);

        /// <summary>
        /// Async inserts the objects from the container into the data source.
        /// </summary>
        /// <returns>The operation ticket identifier.</returns>
        Task<Guid> CreateContainerAsync(PersistentProviderOption settings, string dataBaseName, bool confirm, PersistentContainer container);

        /// <summary>
        /// Process the objects from the container into the data source.
        /// </summary>
        /// <returns>The operation ticket identifier.</returns>
        Guid ProcessContainer(PersistentProviderOption settings, string dataBaseName, PersistentStateContainer container);

        /// <summary>
        /// Async process the objects from the container into the data source.
        /// </summary>
        /// <returns>The operation ticket identifier.</returns>
        Task<Guid> ProcessContainerAsync(PersistentProviderOption settings, string dataBaseName, PersistentStateContainer container);

        /// <summary>
        /// Confirms 1C documents (with making 1C entries) if already exists.
        /// </summary>
        /// <returns>The operation ticket identifier.</returns>
        Guid ConfirmContainer(PersistentProviderOption settings, string dataBaseName, PersistentContainer container);

        /// <summary>
        /// Confirms 1C documents (with making 1C entries) if already exists.
        /// </summary>
        /// <returns>The operation ticket identifier.</returns>
        Task<Guid> ConfirmContainerAsync(PersistentProviderOption settings, string dataBaseName, PersistentContainer container);

        /// <summary>
        /// Checks the status of operation ticket.
        /// </summary>
        /// <returns>The operation ticket object.</returns>
        OperationTicket CheckOperationStatus(PersistentProviderOption settings, Guid ticketId);

        /// <summary>
        /// Async checks the status of operation ticket.
        /// </summary>
        /// <returns>The operation ticket object.</returns>
        Task<OperationTicket> CheckOperationStatusAsync(PersistentProviderOption settings, Guid ticketId);
    }
}
