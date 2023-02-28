using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models
{
    public class ItemPrice
    {
        public string GroupNum { get; set; }
        public decimal  BasePriceLiss {get ; set; }
        public string PriceListName { get; set; }
        public decimal Factor { get; set; }
        public int PriceListNo { get; set; }
        public string DefaultPrimeCurrency { get; set; }
    }
}
