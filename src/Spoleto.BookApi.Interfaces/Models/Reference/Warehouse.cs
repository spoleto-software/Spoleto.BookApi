using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Склад
    /// </summary>
    public class Warehouse : PersistentObjectBase, IWarehouse
    {
        /// <summary>
        /// Наименование 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Parent, Id
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// Parent
        /// </summary>
        [RelatedKey(nameof(ParentId))]
        public IWarehouse Parent { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Тип склада
        /// </summary>
        public WarehouseType WarehouseType { get; set; }

        /// <summary>
        /// Подразделение, Id
        /// </summary>
        public Guid CompanyDivisionId { get; set; }

        /// <summary>
        /// Подразделение организации
        /// </summary>
        [RelatedKey(nameof(CompanyDivisionId))]
        public ICompanyDivision CompanyDivision { get; set; }
    }
}
