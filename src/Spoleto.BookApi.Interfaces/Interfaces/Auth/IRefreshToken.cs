using System;

namespace Spoleto.BookApi.Interfaces.Auth
{
    /// <summary>
    /// The refresh token.
    /// </summary>
    public interface IRefreshToken : IPersistentObjectBase
    {
        /// <summary>
        /// Gets or sets the hash value for this refresh token.
        /// </summary>
        string ValueToken { get; set; }

        /// <summary>
        /// Gets or sets the active flag of this token.
        /// </summary>
        bool Active { get; set; }

        /// <summary>
        /// Gets or sets the date issued in UTC of this token.
        /// </summary>
        DateTime DateIssued { get; set; }

        /// <summary>
        /// Gets or sets the date expires in UTC of this token.
        /// </summary>
        DateTime DateExpires { get; set; }

        /// <summary>
        /// Gets or sets the target user identifier for this refresh token.
        /// </summary>
        Guid UserId { get; set; }
    }
}