using System;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Базовый интерфейс для всех бизнес моделей, используемых при обмене данными с 1С (DTO).
    /// </summary>
    public interface IPersistentObjectBase
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        Guid? Identity { get; set; }
    }
}
