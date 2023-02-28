using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eternity1._0.Models
{
    public class Item
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string VatLiable { get; set; }
        public string TaxType { get; set; }
        public string NCMCode { get; set; }
        public string IndirectTax { get; set; }
        public char ItemType { get; set; }
        public string Mainsupplier { get; set; }
        public int ItemsGroupCode { get; set; }
        public decimal SalesUnitWeight { get; set; }
        public int SalesWeightUnit { get; set; }
        public decimal InventoryWeight { get; set; }
        public decimal SalesItemsPerUnit { get; set; }
        public string PlanningSystem { get; set; }
        public string ProcurementMethod { get; set; }
        public string BarCode { get; set; }
        public string U_CLASIF_STORE { get; set; }
        public string U_codigo { get; set; }
        public string SalesUnit { get; set; }
        public decimal SalesQtyPerPackUnit { get; set; }
        public string InventoryUOM { get; set; }
        public string PurchaseUnit { get; set; }
        public string PurchasePackagingUnit { get; set; }
        public string SalesPackagingUnit { get; set; }
        public string SWW { get; set; }

        /* +++ PROPIEDADES  +++ */
        public string Properties1 { get; set; } //Linea
        public string Properties2 { get; set; } //Mixto
        public string Properties3 { get; set; } //Casa
        public string Properties4 { get; set; }  //ProductoN
        public string Properties5 { get; set; }  //LAColors
        public string Properties6 { get; set; }  //RubyRose
        public string Properties7 { get; set; }  //IMNatural
        public string Properties8 { get; set; }//peaceGlos
        public string Properties9 { get; set; }  //Curtis
        public string Properties10 { get; set; } //Moda
        public string Properties11 { get; set; } //Temporada
        public string Properties12 { get; set; } //AretesP
        public string Properties13 { get; set; } //AnilloP
        public string Properties14 { get; set; } //Collar
        public string Properties15 { get; set; } //CabelloApple
        public string Properties16 { get; set; } //AccesoriosApple
        public string Properties17 { get; set; } //PestanasApple
        public string Properties18 { get; set; } //AplicadoresApple
        public string Properties19 { get; set; } //DepiladoresApple
        public string Properties20 { get; set; } //LapizAND
        public string Properties21 { get; set; } //CosmeticoMega
        public string Properties22 { get; set; } //DonasValerinas
        public string Properties23 { get; set; } //BrosPasCucas
        public string Properties24 { get; set; } //PinzasDiademas
        public string Properties25 { get; set; } //LigasColetero
        public string Properties26 { get; set; } //Naturone
        public string Properties27 { get; set; } //Prosa41
        public string Properties28 { get; set; } //Postizas
        public string Properties29 { get; set; } //Hogar
        public string Properties30 { get; set; } //Cocina
        public string Properties31 { get; set; } //Juguetes
        public string Properties32 { get; set; } //Escritura
        public string Properties33 { get; set; } //CortaPega
        public string Properties34 { get; set; } //EmpaquesRegalo
        public string Properties35 { get; set; } //Ultramo
        public string Properties36 { get; set; } //Remate
        public string Properties37 { get; set; } //Importacion
        public string Properties38 { get; set; } //TempSep
        public string Properties39 { get; set; } //TempHal
        public string Properties40 { get; set; } //TempNav
        public string Properties41 { get; set; } //Fiesta
        public string Properties42 { get; set; } //CajaCerrada
        public string Properties43 { get; set; } //Nails
        public string Properties44 { get; set; } //AccesoriosMegaline
        public string Properties45 { get; set; }//CabelloMegaline
        public string Properties46 { get; set; } //AccesoriosAND
        public string Properties47 { get; set; } //CabelloAND
        public string Properties48 { get; set; } //PestanaAND
        public string Properties49 { get; set; } //DepiladoresAND
        public string Properties50 { get; set; } //AplicadoresAND
        public string Properties51 { get; set; } //HebleeCosmetics
        public string Properties52 { get; set; } //Marcas
        public string Properties53 { get; set; } //Rostro
        public string Properties54 { get; set; } //Ojos
        public string Properties55 { get; set; } //Labios
        public string Properties56 { get; set; } //CuidadoPiel
        public string Properties57 { get; set; } //AccesorioBelleza
        public string Properties58 { get; set; } //Bissu
        public string Properties59 { get; set; } //Maravilla
        public string Properties60 { get; set; } //ByApple
        public string Properties61 { get; set; } //Saniye
        public string Properties62 { get; set; } //Pink21
        public string Properties63 { get; set; } //AmorUs
        public string Properties64 { get; set; } //DanzonCosmetics

        /* +++Listas de Precios+++ */
        public List<ItemPrice> ItemPrice { get; set; }

        /* +++Listas de Almacenes+++ */
        public List<WarehouseInfo> ItemWarehouseInfoCollection { get; set; }
    }
}
