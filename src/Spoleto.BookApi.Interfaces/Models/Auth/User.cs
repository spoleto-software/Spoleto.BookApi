using System;

namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The user for database authentication.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public virtual Guid? Id { get; set; }

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
        /// <remarks>
        /// It is required if <see cref="Email"/> is not initialized.<br/>
        /// In this case <see cref="Phone"/> is expected to be unique.
        /// </remarks>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the user's email address.
        /// </summary>
        /// <remarks>
        /// It is required if <see cref="Phone"/> is not initialized.<br/>
        /// In this case <see cref="Email"/> is expected to be unique.
        /// </remarks>
        public string Email { get; set; }

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
