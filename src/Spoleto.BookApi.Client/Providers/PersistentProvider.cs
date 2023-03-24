using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Spoleto.Common.Extensions;
using Spoleto.Common.Helpers;

namespace Spoleto.BookApi.Client.Providers
{
    public partial class PersistentProvider : IPersistentProvider
    {
        /// <summary>
        /// HttpClientWithDefaultCredentialsName.
        /// </summary>
        public const string HttpClientWithDefaultCredentialsName = "WithDefaultCredentials";

        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<PersistentProvider> _logger;
        private readonly HttpClient _httpClient;

        public PersistentProvider(IHttpClientFactory httpClientFactory, ILogger<PersistentProvider> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        /// <summary>
        /// Use external instance of <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="httpClient"></param>
        private PersistentProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Creates the provider with the external instance of <see cref="HttpClient"/>.
        /// </summary>
        public static PersistentProvider CreateProviderWithHttpClient(HttpClient httpClient) => new PersistentProvider(httpClient);

        private void InitHeaders(HttpRequestMessage requestMessage, PersistentProviderOption settings)
        {
            requestMessage.ConfigureRequestMessage();
        }

        private async Task<T> InvokeAsync<T>(PersistentProviderOption settings, Uri uri, HttpMethod method, string requestJsonContent = null)
        {
            bool byHttpClientFactory;
            HttpClient client;
            if (_httpClient != null)
            {
                client = _httpClient;
                byHttpClientFactory = false;
            }
            else
            {
                client = _httpClientFactory.CreateClient(HttpClientWithDefaultCredentialsName);
                byHttpClientFactory = true;
            }

            try
            {
                client.ConfigureHttpClient();

                using (var requestMessage = new HttpRequestMessage(method, uri))
                {
                    InitHeaders(requestMessage, settings);
                    if (requestJsonContent != null)
                    {
                        requestMessage.Content = new StringContent(requestJsonContent, DefaultSettings.Encoding, DefaultSettings.ContentType);
                    }

                    using (var responseMessage = await client.SendAsync(requestMessage).ConfigureAwait(false))
                    {
                        if (responseMessage.IsSuccessStatusCode)
                        {
                            var result = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                            var objectResult = JsonHelper.FromJson<T>(result);
                            return objectResult;
                        }

                        var errorResult = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
                        if (!String.IsNullOrEmpty(errorResult))
                        {
                            if (responseMessage.Content.Headers.ContentType.MediaType == Spoleto.Common.ContentTypes.ApplicationJson)
                            {
                                //todo: десериализовать Json в объект
                                _logger.LogError(errorResult);
                                throw new Exception(errorResult);
                            }
                            else
                            {
                                _logger.LogError(errorResult);
                                throw new Exception(errorResult);
                            }
                        }
                        else
                        {
                            _logger.LogError(responseMessage.ReasonPhrase);
                            throw new Exception(responseMessage.ReasonPhrase);
                        }
                    }
                }
            }
            finally
            {
                // Dispose the httpClient if we used httpClientFactory to create the current instance of the httpClient:
                if (byHttpClientFactory)
                    client.Dispose();
            }
        }

        private IPersistentProvider Provider => this;
    }
}
