using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The user group for database authentication.
    /// </summary>
    public class Group : PersistentObjectBase
    {
        /// <summary>
        /// Gets or sets the group's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the users belonging to this group.
        /// </summary>
        public List<User> Users { get; set; }
    }
}
