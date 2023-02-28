using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models
{
    public class VendorPayment
    {
        public int DocNum { get; set; }
        public string DocDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string CashAccount { get; set; }
        public decimal CashSum { get; set; }

    }
}
