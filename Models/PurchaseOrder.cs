using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models
{
    public class PurchaseOrder
    {
        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string DocDate { get; set; }
        public string DocDueDate { get; set; }
        public VendorPayment CardCode { get; set; }
        public decimal DocTotal { get; set; }
        public string Comments { get; set; }
        public decimal DiscountPercente { get; set; }
        public decimal VatSum { get; set; }
        public decimal VatSumSys { get; set; }
        public decimal DocTotalFc { get; set; }
        public decimal DocTotalSys { get; set; }
        public string PaymentMethod { get; set; }
        public string Address { get; set; }
        public string SWW { get; set; }
        public string U_TipoCompra { get; set; }

        public List<Item> DocumentLines { get; set; }
    }
}
