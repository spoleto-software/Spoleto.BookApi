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
        Added = 1,

        /// <summary>
        /// Объект изменён.
        /// </summary>
        Changed = 2,

        /// <summary>
        /// Объект удалён.
        /// </summary>
        Removed = 3,
    }
}