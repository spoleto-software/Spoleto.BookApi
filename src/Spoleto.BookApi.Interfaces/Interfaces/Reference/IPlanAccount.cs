using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// План счетов
    /// </summary>
    public interface IPlanAccount : IPersistentReference
    {
        /// <summary>
        /// Код
        /// </summary>
       string Code { get; set; }

       /// <summary>
       /// Наименование
       /// </summary>
       string Description { get; set; }
    }
}
