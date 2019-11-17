using CatalogParser.Enums;
using System;
using System.Collections.Generic;

namespace CatalogParser.Models
{
    public class TotalsModel : TotalsParseModel
    {
        public string City { get; set; }
        public StoreType StoreType { get; set; }

        public override string ToString()
        {
            return $"{ItemNo}\t{City}\t{StoreType.ToString()}\t- {Quantity}";
        }
    }

    public class TotalsParseModel
    {
        public string ItemNo { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"{ItemNo}\t- {Quantity}";
        }
    }

    public class TotalsParseModelEqualityComparer : IEqualityComparer<TotalsModel>
    {
        public bool Equals(TotalsModel x, TotalsModel y)
        {
            return x.ItemNo.Equals(y.ItemNo, StringComparison.CurrentCultureIgnoreCase) &&
                   x.City.Equals(y.City, StringComparison.CurrentCultureIgnoreCase) && x.StoreType.Equals(y.StoreType);
        }

        public int GetHashCode(TotalsModel obj)
        {
            return obj.GetHashCode();
        }
    }
}