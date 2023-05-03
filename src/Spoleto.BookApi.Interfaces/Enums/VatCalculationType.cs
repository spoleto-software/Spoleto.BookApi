using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public enum VatCalculationType
    {
        /// <summary>
        /// НДС сверху
        /// </summary>
        VatOnTop,

        /// <summary>
        /// НДС в сумме
        /// </summary>
        VatInSum
    }
}
