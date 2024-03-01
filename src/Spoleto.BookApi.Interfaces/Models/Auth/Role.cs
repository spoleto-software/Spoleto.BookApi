using System;
using System.Collections.Generic;
using Spoleto.BookApi.Interfaces.Auth;

namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The user role for database authentication.
    /// </summary>
    public class Role : PersistentObjectBase, IRole
    {
        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the users belonging to this role.
        /// </summary>
        public List<User> Users { get; set; }
    }
}
