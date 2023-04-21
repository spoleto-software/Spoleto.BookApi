
using Spoleto.BookApi.Interfaces.Models;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// ГТД
    /// </summary>
    public class CargoCustomsDeclaration : PersistentObjectBase, ICargoCustomsDeclaration
    {
        /// <summary>
        /// Регистрационный номер
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Note { get; set; }
    }
}
