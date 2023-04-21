
namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// ГТД
    /// </summary>
    public interface ICargoCustomsDeclaration : IPersistentReference
    {
        /// <summary>
        /// Регистрационный номер
        /// </summary>
        string Number { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        string Note{ get; set; }
    }
}
