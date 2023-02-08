using System;
//using System.ComponentModel.DataAnnotations;

namespace Spoleto.BookApi.Interfaces.Models
{
    public abstract class PersistentObjectBase : IPersistentObjectBase
    {
        //[Key]
        public Guid? Identity { get; set; }
    }
}
