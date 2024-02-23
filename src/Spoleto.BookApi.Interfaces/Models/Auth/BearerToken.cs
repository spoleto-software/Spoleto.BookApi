namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The Bearer token.
    /// </summary>
    public class BearerToken
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        public string RefreshToken { get; set; }
    }
}
