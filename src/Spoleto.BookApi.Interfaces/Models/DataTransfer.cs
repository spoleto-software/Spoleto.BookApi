using System;
using System.Collections.Generic;
using System.Text;

namespace Spoleto.BookApi.Interfaces.Models
{
    public class DataTransfer
    {
        public DataTransfer()
        {
            ItemList = new Dictionary<Guid, IItem>();
            UnitList = new Dictionary<Guid, IUnit>();
            ContributorList = new Dictionary<Guid, IContractor>();
            SuppliesList = new Dictionary<Guid,ISuppliesHeadDocument>();
        }
        public Dictionary<Guid, IItem> ItemList { get; }
        public Dictionary<Guid, IUnit> UnitList { get; }
        public Dictionary<Guid, IContractor> ContributorList { get; }

        public Dictionary<Guid, ISuppliesHeadDocument> SuppliesList { get; }

        public void CheckIds()
        {
            
        }
    }
}
