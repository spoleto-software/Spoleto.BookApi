using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Spoleto.BookApi.Client.Models;
using Spoleto.Common.Extensions;
using Spoleto.Common.Helpers;

namespace Spoleto.BookApi.Client.Providers
{
    public partial class PersistentProvider : IPersistentProvider
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<PersistentProvider> _logger;
        private readonly ITokenProvider _tokenProvider;
        private readonly HttpClient _httpClient;

        private TokenModel _token;

        public PersistentProvider(IHttpClientFactory httpClientFactory, ILogger<PersistentProvider> logger, ITokenProvider tokenProvider)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _tokenProvider = tokenProvider;
        }

        /// <summary>
        /// Use external instance of <see cref="HttpClient"/>.
        /// </summary>
        /// <param name="httpClient"></param>
        private PersistentProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _tokenProvider = new TokenProvider();
        }

        /// <summary>
        /// Creates the provider with the external instance of <see cref="HttpClient"/>.
        /// </summary>
        public static PersistentProvider CreateProviderWithHttpClient(HttpClient httpClient) => new PersistentProvider(httpClient);

        private async Task InitHeadersAsync(HttpRequestMessage requestMessage, PersistentProviderOption settings, HttpClient httpClient)
        {
            requestMessage.ConfigureRequestMessage();

            var token = await GetTokenAsync(settings, httpClient).ConfigureAwait(false);
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
        }

        private async Task<TokenModel> GetTokenAsync(PersistentProviderOption settings, HttpClient httpClient)
        {
            if (_token == null || _token.RefreshToken == null) // no token
            {
                _token = await _tokenProvider.GetTokenAsync(settings, httpClient).ConfigureAwait(false);
            }
            else if (_token.AccessToken == null) // expired access token
            {
                _token = await _tokenProvider.RefreshTokenAsync(settings, httpClient, _token.RefreshToken).ConfigureAwait(false);
                if (_token == null) // refresh token is invalid, e.g. expired, non-active
                {
                    _token = await GetTokenAsync(settings, httpClient);
                }
            }

            return _token;
        }

        private async Task<T> InvokeAsync<T>(PersistentProviderOption settings, Uri uri, HttpMethod method, string requestJsonContent = null, bool canToResetToken = true)
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
                client = _httpClientFactory.CreateClient();
                byHttpClientFactory = true;
            }

            try
            {
                client.ConfigureHttpClient();

                using (var requestMessage = new HttpRequestMessage(method, uri))
                {
                    await InitHeadersAsync(requestMessage, settings, client).ConfigureAwait(false);

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

                        if (responseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized
                            && canToResetToken)
                        {
                            // Кейс с истекшим токеном:
                            // 1. Сбросим текущий токен только один раз.
                            // 2. Далее пробуем получить токен на основе Refresh токена.
                            // 3. Если это не помогло, то, возможно, дело в другом.
                            _token.AccessToken = null;

                            return await InvokeAsync<T>(settings, uri, method, requestJsonContent, canToResetToken: false).ConfigureAwait(false);
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
