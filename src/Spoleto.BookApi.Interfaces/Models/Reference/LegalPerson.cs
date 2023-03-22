using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Юр.лицо
    /// </summary>
    public class LegalPerson : PersistentObjectBase, ILegalPerson
    {      
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime DateCreate { get; set; }

        /// <summary>
        /// Признак закрытия
        /// </summary>
        public bool IsClosed { get; set; }

        /// <summary>
        /// Дата закрытия
        /// </summary>
        public DateTime DateClose { get; set; }

        /// <summary>
        /// Является обособленным подразделением
        /// </summary>
        public bool IsSeparateUnit { get; set; }

        /// <summary>
        /// Районный коэффициент
        /// </summary>
        public bool DistrictCoefficient { get; set; }

        /// <summary>
        /// Префикс
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        public string KPP { get; set; }

        /// <summary>
        /// ОКПО
        /// </summary>
        public string OKPO { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        public string INN { get; set; }

        /// <summary>
        /// Родительское подразделение
        /// </summary>
        public ILegalPerson Parent { get; set; }

    }
}
