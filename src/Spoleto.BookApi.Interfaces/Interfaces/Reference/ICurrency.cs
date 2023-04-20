using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Валюта
    /// </summary>
    public interface ICurrency : IPersistentReference
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set;  }

        /// <summary>
        /// Полное наименование
        /// </summary>
        string FullName { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        string Code { get; set; }

    }
}
