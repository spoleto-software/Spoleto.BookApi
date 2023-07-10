using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Накладная на отгрузку
    /// </summary>
    public interface IWaybillExpend<T> : IWaybillExpendBase 
        where T: IWaybillItemExpend
    {
        /// <summary>
        /// Субконто (Номенклатурная группа) Id
        /// </summary>
        Guid? SubcontoNomenclatureGroupId { get; set; }

        /// <summary>
        /// позиции накладной
        /// </summary>
        List<T> WaybillItems { get; set; }
    }
}
