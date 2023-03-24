using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Контейнер, который включает в себя бизнес документы вместе со всеми необходимыми справочниками.
    /// </summary>
    public class PersistentContainer
    {
        /// <summary>
        /// Элементы контейнера.
        /// </summary>
        public List<PersistentContainerItem> Items { get; set; }
    }
}
