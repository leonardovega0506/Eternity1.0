using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models
{
    public class ItemTales
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal SalesUnitWeight { get; set; }
        public string BarCode { get; set; }
        public int ItemsGroupCode { get; set; }
        public string U_codigo { get; set; }
        public decimal QuantityOnStock { get; set; }

        /* +++Listas de Almacenes+++ */
        public List<WarehouseInfo> ItemWarehouseInfoCollection { get; set; }

        //Constructor Tales
        public ItemTales(string barCode, string itemCode, string itemName, int itemsGroupCode, List<WarehouseInfo> itemWarehouseInfo, decimal salesUnitWeight,string u_codigo, decimal quantityOnStock)
        {
            this.BarCode = barCode;
            this.ItemCode = itemCode;
            this.ItemName = itemName;
            this.ItemsGroupCode = itemsGroupCode;
            this.ItemWarehouseInfoCollection = itemWarehouseInfo;
            this.SalesUnitWeight = salesUnitWeight;
            this.U_codigo = u_codigo;
            this.QuantityOnStock = quantityOnStock;
        }
    }
}
