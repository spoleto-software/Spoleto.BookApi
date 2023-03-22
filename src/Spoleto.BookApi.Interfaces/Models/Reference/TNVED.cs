using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class TNVED: PersistentObjectBase, ITNVED
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// код
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// сырьевой товар
        /// </summary>
        public bool IsRawProduct { get; set; }
    }
}
