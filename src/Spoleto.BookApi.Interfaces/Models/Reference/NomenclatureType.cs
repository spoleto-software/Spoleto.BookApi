using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class NomenclatureType : PersistentObjectBase, INomenclatureType
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Является услугой
        /// </summary>
        public bool IsService { get; set; }
    }
}
