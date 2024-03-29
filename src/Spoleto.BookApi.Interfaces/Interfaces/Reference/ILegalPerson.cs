﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Юр.лицо
    /// </summary>
    public interface ILegalPerson : IPersistentReference
    {
        /// <summary>
        /// Название
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        string Code { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        DateTime DateCreate { get; set; }

        /// <summary>
        /// Признак закрытия
        /// </summary>
        bool IsClosed { get; set; }

        /// <summary>
        /// Дата закрытия
        /// </summary>
        DateTime DateClose { get; set; }

        /// <summary>
        /// Является обособленным подразделением
        /// </summary>
        bool IsSeparateUnit { get; set; }

        /// <summary>
        /// Районный коэффициент
        /// </summary>
        bool DistrictCoefficient { get; set; }

        /// <summary>
        /// Префикс
        /// </summary>
        string Prefix { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        string KPP { get; set; }

        /// <summary>
        /// ОКПО
        /// </summary>
        string OKPO { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        string INN { get; set; }

        /// <summary>
        /// Родительское подразделение
        /// </summary>
        ILegalPerson Parent { get; set; }

    }
}
