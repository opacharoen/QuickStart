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
    
    public partial class WasteWarehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WasteWarehouse()
        {
            this.WasteWarehouseDetails = new HashSet<WasteWarehouseDetails>();
        }
    
        public int Id { get; set; }
        public int FKProduct { get; set; }
        public int FKWarehouse { get; set; }
        public decimal QtyUnit { get; set; }
        public decimal QtyPiece { get; set; }
        public string Description { get; set; }
        public bool Enable { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WasteWarehouseDetails> WasteWarehouseDetails { get; set; }
    }
}