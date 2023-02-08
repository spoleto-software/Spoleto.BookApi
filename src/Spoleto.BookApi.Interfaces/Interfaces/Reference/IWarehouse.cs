using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IWarehouse : IPersistentReference
    {

        /// <summary>
        /// Наименование 
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Parent, Id
        /// </summary>
        Guid ParentId { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        [RelatedKey(nameof(ParentId))]
        IWarehouse Parent { get; set; }

        /// <summary>
        /// Является группой
        /// </summary>
        bool IsGroup { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        string Note { get; set; }

        /// <summary>
        /// Тип склада
        /// </summary>
        WarehouseType WarehouseType { get; set; }

        /// <summary>
        /// Подразделение, Id
        /// </summary>
        Guid CompanyDivisionId { get; set; }

        /// <summary>
        /// Подразделение организации
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionId))]
        ICompanyDivision CompanyDivision { get; set; }
    }
}
