//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickStart
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.CheckStockPos = new HashSet<CheckStockPos>();
            this.PosStock = new HashSet<PosStock>();
            this.StoreFrontStock = new HashSet<StoreFrontStock>();
            this.CostProductChangeLog = new HashSet<CostProductChangeLog>();
            this.ProductDetails = new HashSet<ProductDetails>();
            this.WasteWarehouse = new HashSet<WasteWarehouse>();
            this.WmsStock = new HashSet<WmsStock>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string ThaiName { get; set; }
        public string EnglishName { get; set; }
        public string Description { get; set; }
        public string Description1 { get; set; }
        public int FKUnitCheckStock { get; set; }
        public int FKUnitAddStock { get; set; }
        public int FKUnitBuy { get; set; }
        public int FKProductPosCollect { get; set; }
        public int FKProductVatType { get; set; }
        public bool IsSale { get; set; }
        public bool IsBuy { get; set; }
        public bool Enable { get; set; }
        public int FKCostType { get; set; }
        public string ProductRemerk { get; set; }
        public int FKProductCategory { get; set; }
        public int FKProductGroup { get; set; }
        public int FKSupplier { get; set; }
        public int FKVender { get; set; }
        public int FKProductBrand { get; set; }
        public int FKProductSize { get; set; }
        public int FKProductColor { get; set; }
        public int FKZone { get; set; }
        public string CheerMessage1 { get; set; }
        public string CheerMessage2 { get; set; }
        public string CheerMessage3 { get; set; }
        public string LabelMessage { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int FKRowID { get; set; }
        public bool IsProcessingGoods { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheckStockPos> CheckStockPos { get; set; }
        public virtual CostType CostType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosStock> PosStock { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual ProductPosCollectPoints ProductPosCollectPoints { get; set; }
        public virtual ProductSize ProductSize { get; set; }
        public virtual ProductVatType ProductVatType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreFrontStock> StoreFrontStock { get; set; }
        public virtual Vendor Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CostProductChangeLog> CostProductChangeLog { get; set; }
        public virtual ProductBrands ProductBrands { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDetails> ProductDetails { get; set; }
        public virtual ProductGroups ProductGroups { get; set; }
        public virtual ProductUnit ProductUnit { get; set; }
        public virtual ProductUnit ProductUnit1 { get; set; }
        public virtual ProductUnit ProductUnit2 { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Zone Zone { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WasteWarehouse> WasteWarehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WmsStock> WmsStock { get; set; }
    }
}