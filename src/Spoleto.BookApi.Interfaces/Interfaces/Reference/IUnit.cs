using System;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Справочник единиц измерения
    /// </summary>
    public interface IUnit : IPersistentReference
    {

        /// <summary>
        /// Краткое наименование единицы измерения
        /// </summary>
        string ShortName { get; set; }

        /// <summary>
        /// Полное наименование единицы измерения
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string Code { get; set; }
    }
}
