using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class Unit : PersistentObjectBase, IUnit
    {
        /// <summary>
        /// Краткое наименование единицы измерения
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Полное наименование единицы измерения
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string Code { get; set; }
    }
}
