using System;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Базовый интерфейс для всех бизнес моделей, используемых при обмене данными с 1С (DTO).
    /// </summary>
    public interface IPersistentObjectBase
    {
        /// <summary>
        /// ID документа
        /// </summary>
        Guid? Identity { get; set; }

        /// <summary>
        /// Дополнительные параметры
        /// </summary>
        ///   Dictionary<string, object> AdditionalParameters {get ;set; }

    }
}
