using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class Shop : PersistentObjectBase, IShop
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Prefix { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime? DateClose { get; set; }

        public ICompanyDivision CompanyDivision { get; set; }
    }
}
