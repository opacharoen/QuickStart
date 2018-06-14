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
    
    public partial class RcvHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RcvHeader()
        {
            this.RcvDetails = new HashSet<RcvDetails>();
        }
    
        public int Id { get; set; }
        public string DocumentNo { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public int FKWarehouse { get; set; }
        public int FKRcvType { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public bool Enable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RcvDetails> RcvDetails { get; set; }
        public virtual RcvType RcvType { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}