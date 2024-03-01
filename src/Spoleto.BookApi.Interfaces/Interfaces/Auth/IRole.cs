namespace Spoleto.BookApi.Interfaces.Auth
{
    /// <summary>
    /// The user role for database authentication.
    /// </summary>
    public interface IRole : IPersistentObjectBase
    {
        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        string Name { get; set; }
    }
}