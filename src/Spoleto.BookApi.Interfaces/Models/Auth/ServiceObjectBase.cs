using System;

namespace Spoleto.BookApi.Interfaces.Models.Auth
{
    /// <summary>
    /// The objects used as part of the Web API service.
    /// </summary>
    public class ServiceObjectBase : IPersistentObjectBase
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid? Identity { get; set; }
    }
}
