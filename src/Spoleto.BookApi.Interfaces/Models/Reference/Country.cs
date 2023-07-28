using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class Country : PersistentObjectBase, ICountry
    {

        public string Name { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Двузначный код страны (альфа-2)
        /// </summary>
        public string CodeAlpha2 { get; set; }

        /// <summary>
        /// Трехзначный код страны (альфа-3)
        /// </summary>
        public string CodeAlpha3 { get; set; }

        /// <summary>
        /// Является участником ЕАЭС
        /// </summary>
        public bool EAEUMember { get; set; }

        /// <summary>
        /// Международное наименование
        /// </summary>
        public string InternationalName { get; set; }
    }
}
