using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{

    /// <summary>
    /// Номенклатурная группа
    /// </summary>
    public class NomenclatureGroup : PersistentObjectBase, INomenclatureGroup
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
    }
}
