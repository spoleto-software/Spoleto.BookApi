using System;
using System.Net.Http;
using System.Threading.Tasks;
using Spoleto.BookApi.Interfaces.Models;
using Spoleto.BookApi.Interfaces.Models.OperationTicket;
using Spoleto.Common.Helpers;

namespace Spoleto.BookApi.Client.Providers
{
    public partial class PersistentProvider
    {
        OperationTicketResult IPersistentProvider.CreateContainer(PersistentProviderOption settings, string dataBaseName, bool confirm, PersistentContainer container)
            => Provider.CreateContainerAsync(settings, dataBaseName, confirm, container).GetAwaiter().GetResult();

        async Task<OperationTicketResult> IPersistentProvider.CreateContainerAsync(PersistentProviderOption settings, string dataBaseName, bool confirm, PersistentContainer container)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/PersistentObject/Container/{dataBaseName}/{confirm}");

            var jsonModel = JsonHelper.ToJson(container);
            var obj = await InvokeAsync<OperationTicketResult>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return obj;
        }

        OperationTicketResult IPersistentProvider.ProcessContainer(PersistentProviderOption settings, string dataBaseName, PersistentStateContainer container)
            => Provider.ProcessContainerAsync(settings, dataBaseName, container).GetAwaiter().GetResult();

        async Task<OperationTicketResult> IPersistentProvider.ProcessContainerAsync(PersistentProviderOption settings, string dataBaseName, PersistentStateContainer container)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/PersistentObject/Container/Process/{dataBaseName}");

            var jsonModel = JsonHelper.ToJson(container);
            var obj = await InvokeAsync<OperationTicketResult>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return obj;
        }

        /// <summary>
        /// Confirm 1C documents (with making 1C entries) if already exists.
        /// </summary>
        OperationTicketResult IPersistentProvider.ConfirmContainer(PersistentProviderOption settings, string dataBaseName, PersistentContainer container)
        => Provider.ConfirmContainerAsync(settings, dataBaseName, container).GetAwaiter().GetResult();


        /// <summary>
        /// Confirm 1C documents (with making 1C entries) if already exists.
        /// </summary>
        async Task<OperationTicketResult> IPersistentProvider.ConfirmContainerAsync(PersistentProviderOption settings, string dataBaseName, PersistentContainer container)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/PersistentObject/Container/Confirm/{dataBaseName}");

            var jsonModel = JsonHelper.ToJson(container);
            var obj = await InvokeAsync<OperationTicketResult>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return obj;
        }

        OperationTicket IPersistentProvider.CheckOperationStatus(PersistentProviderOption settings, Guid ticketId)
            => Provider.CheckOperationStatusAsync(settings, ticketId).GetAwaiter().GetResult();

        async Task<OperationTicket> IPersistentProvider.CheckOperationStatusAsync(PersistentProviderOption settings, Guid ticketId)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/PersistentObject/Container/CheckStatus/{ticketId}");

            var obj = await InvokeAsync<OperationTicket>(settings, uri, HttpMethod.Get).ConfigureAwait(false);

            return obj;
        }
    }
}
