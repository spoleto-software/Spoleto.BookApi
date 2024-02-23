using System;

namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The refresh token.
    /// </summary>
    public class RefreshToken : PersistentObjectBase
    {
        /// <summary>
        /// Gets or sets the hash value for this refresh token.
        /// </summary>
        public string ValueToken { get; set; }

        /// <summary>
        /// Gets or sets the active flag of this token.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the date issued in UTC of this token.
        /// </summary>
        public DateTime DateIssued { get; set; }

        /// <summary>
        /// Gets or sets the date expires in UTC of this token.
        /// </summary>
        public DateTime DateExpires { get; set; }

        /// <summary>
        /// Gets or sets the target user identifier for this refresh token.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the target user for this refresh token.
        /// </summary>
        public User User { get; set; }
    }
}
