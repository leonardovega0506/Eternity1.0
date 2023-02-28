using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models
{
    public class WarehouseInfo
    {
        public decimal MinimalStock { get; set; }
        public decimal InStock { get; set; }
        public decimal Commited { get; set; }
        public string WarehouseCode { get; set; }
        public decimal Ordered { get; set; }
    }
}
