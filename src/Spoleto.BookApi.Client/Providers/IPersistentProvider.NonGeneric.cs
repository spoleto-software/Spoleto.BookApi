using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Client.Providers
{
    public partial interface IPersistentProvider
    {
        /// <summary>
        /// Inserts the objects from the container into the data source.
        /// </summary>
        PersistentContainer CreateContainer(PersistentProviderOption settings, string dataBaseName, PersistentContainer container);

        /// <summary>
        /// Async inserts the objects from the container into the data source.
        /// </summary>
        Task<PersistentContainer> CreateContainerAsync(PersistentProviderOption settings, string dataBaseName, PersistentContainer container);

        /// <summary>
        /// Process the objects from the container into the data source.
        /// </summary>
        PersistentStateContainer ProcessContainer(PersistentProviderOption settings, string dataBaseName, PersistentStateContainer container);

        /// <summary>
        /// Async process the objects from the container into the data source.
        /// </summary>
        Task<PersistentStateContainer> ProcessContainerAsync(PersistentProviderOption settings, string dataBaseName, PersistentStateContainer container);

        /// <summary>
        /// Confirm 1C documents (with making 1C entries) if already exists.
        /// </summary>
        PersistentContainer ConfirmContainer(PersistentProviderOption settings, string dataBaseName, PersistentContainer container);


        /// <summary>
        /// Confirm 1C documents (with making 1C entries) if already exists.
        /// </summary>
        Task<PersistentContainer> ConfirmContainerAsync(PersistentProviderOption settings, string dataBaseName, PersistentContainer container);
    }
}
