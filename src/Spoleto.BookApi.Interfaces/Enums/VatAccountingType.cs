
namespace Spoleto.BookApi.Interfaces
{
    public enum VatAccountingType
    {
        /// <summary>
        /// ВосстановленДляОперацийПо0
        /// </summary>
        RestoredForOperationsBy0,

        /// <summary>
        /// ВосстановленУчитываетсяВCтоимости
        /// </summary>
        RestoredIncludeInAmount,

        /// <summary>
        /// ДляОперацийПо0
        /// </summary>
        ForOperationsBy0,

        /// <summary>
        /// ПринимаетсяКВычету
        /// </summary>
        IsDeductible,

        /// <summary>
        /// Распределен
        /// </summary>
        Distributed,

        /// <summary>
        /// Распределяется
        /// </summary>
        Distributes,

        /// <summary>
        /// Списывается
        /// </summary>
        WritesOff,

        /// <summary>
        /// УчитываетсяВCтоимости
        /// </summary>
        IncludeInAmount

    }
}
