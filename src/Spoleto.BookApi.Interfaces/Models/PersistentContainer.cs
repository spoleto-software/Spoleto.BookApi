using System.Collections.Generic;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Контейнер, который включает бизнес документы вместе со всеми необходимыми справочниками.
    /// </summary>
    public class PersistentContainer
    {
        public List<IPersistentReference> ReferenceList { get; set; }

        public List<IPersistentDocument> DocumentList { get; set; }
    }

    public class PersistentContainer<T> : PersistentContainer where T: IPersistentObjectBase
    {
        public new List<T> DocumentList { get; set; }
    }
}
