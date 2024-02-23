namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The request for token refresh.
    /// </summary>
    public class RefreshRequest
    {
        /// <summary>
        /// Gests or sets the refresh token.
        /// </summary>
        public string RefreshToken { get; set; }
    }
}
