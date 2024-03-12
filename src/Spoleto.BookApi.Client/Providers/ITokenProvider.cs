using System.Net.Http;
using System.Threading.Tasks;
using Spoleto.BookApi.Client.Models;

namespace Spoleto.BookApi.Client.Providers
{
    /// <summary>
    /// Провайдер для получения токенов Bearer.
    /// </summary>
    public interface ITokenProvider
    {
        /// <summary>
        /// Метод для получения токена.
        /// </summary>
        /// <param name="settings">Настройки провайдера.</param>
        /// <param name="httpClient">Http клиент.</param>
        /// <returns>Токена доступа.</returns>
        TokenModel GetToken(PersistentProviderOption settings, HttpClient httpClient);

        /// <summary>
        /// Метод для получения токена.
        /// </summary>
        /// <param name="settings">Настройки провайдера.</param>
        /// <param name="httpClient">Http клиент.</param>
        /// <returns>Токена доступа.</returns>
        Task<TokenModel> GetTokenAsync(PersistentProviderOption settings, HttpClient httpClient);

        /// <summary>
        /// Метод для получения токена на основе Refresh токена.
        /// </summary>
        /// <param name="settings">Настройки провайдера.</param>
        /// <param name="httpClient">Http клиент.</param>
        /// <param name="refreshToken">Refresh токен.</param>
        /// <returns>Токена доступа.</returns>
        TokenModel RefreshToken(PersistentProviderOption settings, HttpClient httpClient, string refreshToken);

        /// <summary>
        /// Метод для получения токена на основе Refresh токена.
        /// </summary>
        /// <param name="settings">Настройки провайдера.</param>
        /// <param name="httpClient">Http клиент.</param>
        /// <param name="refreshToken">Refresh токен.</param>
        /// <returns>Токена доступа.</returns>
        Task<TokenModel> RefreshTokenAsync(PersistentProviderOption settings, HttpClient httpClient, string refreshToken);
    }
}
