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
    
    public partial class ReceiptAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceiptAddress()
        {
            this.RePrintReceiptLog = new HashSet<RePrintReceiptLog>();
        }
    
        public int Id { get; set; }
        public string CompCode { get; set; }
        public bool Enable { get; set; }
        public string CompName { get; set; }
        public string CompAddress { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string TaxId { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RePrintReceiptLog> RePrintReceiptLog { get; set; }
    }
}
