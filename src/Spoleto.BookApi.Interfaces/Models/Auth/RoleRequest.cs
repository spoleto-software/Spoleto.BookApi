namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The request to create/update the user role.
    /// </summary>
    public class RoleRequest
    {
        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        public string Name { get; set; }
    }
}
