using System.Threading.Tasks;
using System;
using Spoleto.BookApi.Interfaces.Models;
using Spoleto.Common.Helpers;
using System.Net.Http;

namespace Spoleto.BookApi.Client.Providers
{
    public partial class PersistentProvider
    {
        PersistentContainer IPersistentProvider.CreateContainer(PersistentProviderOption settings, string dataBaseName, PersistentContainer container)
            => Provider.CreateContainerAsync(settings, dataBaseName, container).GetAwaiter().GetResult();

        async Task<PersistentContainer> IPersistentProvider.CreateContainerAsync(PersistentProviderOption settings, string dataBaseName, PersistentContainer container)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/PersistentObject/Container/{dataBaseName}");

            var jsonModel = JsonHelper.ToJson(container);
            var obj = await InvokeAsync<PersistentContainer>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return obj;
        }

        PersistentStateContainer IPersistentProvider.ProcessContainer(PersistentProviderOption settings, string dataBaseName, PersistentStateContainer container)
            => Provider.ProcessContainerAsync(settings, dataBaseName, container).GetAwaiter().GetResult();

        async Task<PersistentStateContainer> IPersistentProvider.ProcessContainerAsync(PersistentProviderOption settings, string dataBaseName, PersistentStateContainer container)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/PersistentObject/Container/Process/{dataBaseName}");

            var jsonModel = JsonHelper.ToJson(container);
            var obj = await InvokeAsync<PersistentStateContainer>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return obj;
        }

        /// <summary>
        /// Confirm 1C documents (with making 1C entries) if already exists.
        /// </summary>
        PersistentContainer IPersistentProvider.ConfirmContainer(PersistentProviderOption settings, string dataBaseName, PersistentContainer container)
        => Provider.ConfirmContainerAsync(settings, dataBaseName, container).GetAwaiter().GetResult();


        /// <summary>
        /// Confirm 1C documents (with making 1C entries) if already exists.
        /// </summary>
        async Task<PersistentContainer> IPersistentProvider.ConfirmContainerAsync(PersistentProviderOption settings, string dataBaseName, PersistentContainer container)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), $"api/PersistentObject/Container/Confirm/{dataBaseName}");

            var jsonModel = JsonHelper.ToJson(container);
            var obj = await InvokeAsync<PersistentContainer>(settings, uri, HttpMethod.Post, jsonModel).ConfigureAwait(false);

            return obj;
        }
    }
}
