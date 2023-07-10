using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Номенклатурная группа
    /// </summary>
    public interface INomenclatureGroup : IPersistentReference
    {
        /// <summary>
        /// Название
        /// </summary>
        string Name { get; set; }
    }
}
