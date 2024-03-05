using System;

namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The user for database authentication.
    /// </summary>
    public class User : ServiceObjectBase, Spoleto.BookApi.Interfaces.Auth.IUser
    {
        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the user's middle name. Optional, can be null if not provided.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the user's last name. Optional, can be null if not provided.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the user's phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the user's login name.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets the user's password (hash).
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the user role identifier.
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// Gets or sets the user role.
        /// </summary>
        public Role Role { get; set; }
    }
}
