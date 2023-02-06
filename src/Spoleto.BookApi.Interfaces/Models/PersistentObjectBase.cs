using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public abstract class PersistentObjectBase : IPersistentObjectBase
    {
        [Key]
        public Guid? Identity { get; set; }
    }
}
