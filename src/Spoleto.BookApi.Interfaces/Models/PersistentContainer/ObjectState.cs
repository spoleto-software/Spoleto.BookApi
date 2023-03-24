namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Состояние объекта.
    /// </summary>
    public enum ObjectState
    {
        /// <summary>
        /// Объект никак не изменён.<br/>
        /// Состояние по умолчанию.
        /// </summary>
        None = 0,

        /// <summary>
        /// Объект создан.
        /// </summary>
        Created = 1,

        /// <summary>
        /// Объект изменён.
        /// </summary>
        Updated = 2,

        /// <summary>
        /// Объект удалён.
        /// </summary>
        Deleted = 3,
    }
}