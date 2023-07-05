using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// Справочник пользователей
    /// </summary>
    public interface IUser : IPersistentReference
    {
        string Name { get; set; }
    }
}
