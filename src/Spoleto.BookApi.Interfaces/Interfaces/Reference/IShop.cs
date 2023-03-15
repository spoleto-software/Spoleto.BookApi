using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public interface IShop : IPersistentReference
    {

        string Name { get; set; }

        string Code { get; set; }

        string Prefix { get; set; }

        DateTime DateCreate { get; set; }

        DateTime? DateClose { get; set; }

        ICompanyDivision CompanyDivision { get; set; }

        //описать список<RefПодразделенияОрганизаций_КонтактнаяИнформация>
    }
}
