using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Контейнер, который включает в себя бизнес документы вместе со всеми необходимыми справочниками.<br/>
    /// Каждый элемент контейнера содержит информацию о своём состоянии (Создан/Изменён/Удалён).
    /// </summary>
    public class PersistentStateContainer
    {
        /// <summary>
        /// Элементы контейнера.
        /// </summary>
        public List<PersistentStateContainerItem> Items { get; set; }
    }
}
