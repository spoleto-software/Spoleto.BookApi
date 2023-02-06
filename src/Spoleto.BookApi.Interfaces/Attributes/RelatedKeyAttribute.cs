using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    /// <summary>
    /// The related key (for object-based properties).
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class RelatedKeyAttribute : Attribute
    {
        public RelatedKeyAttribute(string key)
        {
            Key = key;
        }

        public string Key { get; set; }
    }
}
