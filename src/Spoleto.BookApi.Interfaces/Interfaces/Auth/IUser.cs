using System;

namespace Spoleto.BookApi.Interfaces.Auth
{
    /// <summary>
    /// The user for database authentication.
    /// </summary>
    public interface IUser : IPersistentObjectBase
    {
        /// <summary>
        /// Gets or sets the user's first name.
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the user's middle name. Optional, can be null if not provided.
        /// </summary>
        string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the user's last name. Optional, can be null if not provided.
        /// </summary>
        string LastName { get; set; }

        /// <summary>
        /// Gets or sets the user's phone number.
        /// </summary>
        string Phone { get; set; }

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Gets or sets the user's login name.
        /// </summary>
        string Login { get; set; }

        /// <summary>
        /// Gets or sets the user's password (hash).
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Gets or sets the user role identifier.
        /// </summary>
        Guid RoleId { get; set; }
    }
}