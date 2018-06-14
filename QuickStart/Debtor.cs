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
    
    public partial class Debtor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Debtor()
        {
            this.PosHeader = new HashSet<PosHeader>();
            this.SaleOrderWarehouse = new HashSet<SaleOrderWarehouse>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string TaxNo { get; set; }
        public string LineId { get; set; }
        public string Fax { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public bool Enable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosHeader> PosHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrderWarehouse> SaleOrderWarehouse { get; set; }
    }
}