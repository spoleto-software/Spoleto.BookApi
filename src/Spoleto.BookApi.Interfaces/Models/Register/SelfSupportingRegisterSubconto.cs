using System;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Регистр бухгалтерии - движения с субконто
    /// </summary>
    public class SelfSupportingRegisterSubconto  : SelfSupportingRegister, ISelfSupportingRegisterSubconto
    {
        /// <summary>
        /// Субконто Кт1 , Id
        /// </summary>
        public Guid? SubcontoCt1 { get; set; }

        /// <summary>
        /// Субконто Кт1 , тип 
        /// </summary>
        public SubcontoType? SubcontoCt1Type { get; set; }

        /// <summary>
        /// Субконто Кт2 , Id
        /// </summary>
        public Guid? SubcontoCt2 { get; set; }

        /// <summary>
        /// Субконто Кт2 , тип 
        /// </summary>
        public SubcontoType? SubcontoCt2Type { get; set; }

        /// <summary>
        /// Субконто Дт1 , Id
        /// </summary>
        public Guid? SubcontoDt1 { get; set; }

        /// <summary>
        /// Субконто Дт1 , тип 
        /// </summary>
        public SubcontoType? SubcontoDt1Type { get; set; }

        /// <summary>
        /// Субконто Дт2 , Id
        /// </summary>
        public Guid? SubcontoDt2 { get; set; }

        /// <summary>
        /// Субконто Дт2 , тип 
        /// </summary>
        public SubcontoType? SubcontoDt2Type { get; set; }
    }
}
