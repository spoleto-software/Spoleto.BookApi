namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The login request.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Gets or sets the login.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }
    }
}
