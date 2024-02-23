namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The login request.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// Gets or sets whether the email or the phone.
        /// </summary>
        public string EmailOrPhone { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }
    }
}
