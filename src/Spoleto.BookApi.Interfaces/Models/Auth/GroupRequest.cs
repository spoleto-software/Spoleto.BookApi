namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The request to create/update the user group.
    /// </summary>
    public class GroupRequest
    {
        /// <summary>
        /// Gets or sets the group's name.
        /// </summary>
        public string Name { get; set; }
    }
}
