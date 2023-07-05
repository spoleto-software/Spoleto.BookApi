using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    /// <summary>
    /// Справочник пользователей
    /// </summary>
    public class User : PersistentObjectBase, IUser
    {
        public string Name { get; set; }
    }
}
