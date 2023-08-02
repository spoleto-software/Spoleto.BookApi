using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
     /// <summary>
     /// Виды номенклатуры
     /// </summary>
     public interface INomenclatureType : IPersistentReference
     {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Является услугой
        /// </summary>
        bool IsService { get; set; }
     }
}
