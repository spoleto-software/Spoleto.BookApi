using System;
using System.Net.Http;
using System.Threading.Tasks;
using Spoleto.BookApi.Client.Models;
using Spoleto.BookApi.Interfaces.Models.Auth;
using Spoleto.Common.Helpers;

namespace Spoleto.BookApi.Client.Providers
{
    public class TokenProvider : ITokenProvider
    {
        public TokenModel GetToken(PersistentProviderOption settings, HttpClient httpClient)
            => GetTokenAsync(settings, httpClient).GetAwaiter().GetResult();

        public async Task<TokenModel> GetTokenAsync(PersistentProviderOption settings, HttpClient httpClient)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), "api/token");
            var loginRequest = new LoginRequest
            {
                Login = settings.Login,
                Password = settings.Password
            };

            using (var request = new HttpRequestMessage(HttpMethod.Post, uri))
            {
                request.Content = new StringContent(JsonHelper.ToJson(loginRequest), DefaultSettings.Encoding, DefaultSettings.ContentType);

                var response = await httpClient.SendAsync(request).ConfigureAwait(false);
                var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    TokenModel tokenModel = null;
                    try
                    {
                        tokenModel = JsonHelper.FromJson<TokenModel>(result);
                    }
                    catch (Exception)
                    {
                        throw new Exception($"Ошибка формирования токена доступа\n{result}");
                    }

                    return tokenModel;
                }
                else if (!string.IsNullOrEmpty(result))
                {
                    throw new Exception(result);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public TokenModel RefreshToken(PersistentProviderOption settings, HttpClient httpClient, string refreshToken)
            => RefreshTokenAsync(settings, httpClient, refreshToken).GetAwaiter().GetResult();

        public async Task<TokenModel> RefreshTokenAsync(PersistentProviderOption settings, HttpClient httpClient, string refreshToken)
        {
            var uri = new Uri(new Uri(settings.ServiceUrl), "api/token/refresh");
            var loginRequest = new RefreshRequest
            {
                RefreshToken = refreshToken
            };

            using (var request = new HttpRequestMessage(HttpMethod.Post, uri))
            {
                request.Content = new StringContent(JsonHelper.ToJson(loginRequest), DefaultSettings.Encoding, DefaultSettings.ContentType);

                var response = await httpClient.SendAsync(request).ConfigureAwait(false);
                var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    TokenModel tokenModel = null;
                    try
                    {
                        tokenModel = JsonHelper.FromJson<TokenModel>(result);
                    }
                    catch (Exception)
                    {
                        throw new Exception($"Ошибка формирования токена доступа\n{result}");
                    }

                    return tokenModel;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized) // non-existing or expired or non-active refresh token
                {
                    return null;
                }
                else if (!string.IsNullOrEmpty(result))
                {
                    throw new Exception(result);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
