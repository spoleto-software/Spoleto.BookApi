using System;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// The base persistent object.
    /// </summary>
    public abstract class PersistentObjectBase : IPersistentObjectBase
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid? Identity { get; set; }
    }
}
