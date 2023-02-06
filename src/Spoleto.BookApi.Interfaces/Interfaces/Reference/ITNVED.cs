using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Справочник ТН ВЭД
    /// </summary>
    public interface ITNVED : IPersistentReference
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// код
        /// </summary>
        string Code { get; set; }
        
        /// <summary>
        /// сырьевой товар
        /// </summary>
        bool IsRawProduct { get; set; }


    }
}
