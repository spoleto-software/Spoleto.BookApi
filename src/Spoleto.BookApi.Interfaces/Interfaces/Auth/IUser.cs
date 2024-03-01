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
        /// <remarks>
        /// It is required if <see cref="Email"/> is not initialized.<br/>
        /// In this case <see cref="Phone"/> is expected to be unique.
        /// </remarks>
        string Phone { get; set; }

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        /// <remarks>
        /// It is required if <see cref="Phone"/> is not initialized.<br/>
        /// In this case <see cref="Email"/> is expected to be unique.
        /// </remarks>
        string Email { get; set; }

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