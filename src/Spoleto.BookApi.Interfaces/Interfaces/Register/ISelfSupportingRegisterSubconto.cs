using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Регистр бухгалтерии - движения с субконто
    /// </summary>
    public interface ISelfSupportingRegisterSubconto : ISelfSupportingRegister
    {
        /// <summary>
        /// Субконто Кт1 , Id
        /// </summary>
        Guid? SubcontoCt1 { get; set; }

        /// <summary>
        /// Субконто Кт1 , тип 
        /// </summary>
        SubcontoType? SubcontoCt1Type { get; set; }

        /// <summary>
        /// Субконто Кт2 , Id
        /// </summary>
        Guid? SubcontoCt2 { get; set; }

        /// <summary>
        /// Субконто Кт2 , тип 
        /// </summary>
        SubcontoType? SubcontoCt2Type { get; set; }

        /// <summary>
        /// Субконто Дт1 , Id
        /// </summary>
        Guid? SubcontoDt1 { get; set; }

        /// <summary>
        /// Субконто Дт1 , тип 
        /// </summary>
        SubcontoType? SubcontoDt1Type { get; set; }

        /// <summary>
        /// Субконто Дт2 , Id
        /// </summary>
        Guid? SubcontoDt2 { get; set; }

        /// <summary>
        /// Субконто Дт2 , тип 
        /// </summary>
        SubcontoType? SubcontoDt2Type { get; set; }

    }
}
