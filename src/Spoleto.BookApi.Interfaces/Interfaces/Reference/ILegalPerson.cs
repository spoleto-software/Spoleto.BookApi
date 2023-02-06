using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces
{
    public interface ILegalPerson : IPersistentReference
    {
        string Name { get; set; }

        string Code { get; set; }

        DateTime DateCreate { get; set; }

        bool IsClosed { get; set; }

        DateTime DateClose { get; set; }

        bool IsSeparateUnit { get; set; }

        bool DistrictCoefficient { get; set; }

        string Prefix { get; set; }

        string KPP { get; set; }

        string OKPO { get; set; }

        string INN { get; set; }

        ILegalPerson Parent { get; set; }

    }
}
