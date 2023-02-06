namespace Spoleto.BookApi.Interfaces
{
    public interface IFolder : IPersistentObjectBase
    {
        /// <summary>
        /// Наименование единицы измерения
        /// </summary>
        string Name { get; set; }// Полный путь папок через \
    }
}
