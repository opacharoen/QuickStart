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
    
    public partial class PosHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PosHeader()
        {
            this.CNHeader = new HashSet<CNHeader>();
            this.DebtorPaymentDetails = new HashSet<DebtorPaymentDetails>();
            this.RePrintReceiptLog = new HashSet<RePrintReceiptLog>();
            this.PosDetails = new HashSet<PosDetails>();
            this.PosPromotion = new HashSet<PosPromotion>();
            this.PosUsedPromotion = new HashSet<PosUsedPromotion>();
            this.PrintSlipLog = new HashSet<PrintSlipLog>();
        }
    
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public bool Enable { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int FKMember { get; set; }
        public Nullable<int> FKDebtor { get; set; }
        public decimal TotalBalance { get; set; }
        public Nullable<System.DateTime> PayDate { get; set; }
        public decimal TotalVat { get; set; }
        public decimal TotaNoVat { get; set; }
        public decimal Total { get; set; }
        public decimal TotalDiscountCoupon { get; set; }
        public decimal TotalDiscountShop { get; set; }
        public decimal TotalBeforeVat { get; set; }
        public decimal Discount { get; set; }
        public decimal Cash { get; set; }
        public decimal Change { get; set; }
        public decimal Qty { get; set; }
        public decimal TotalCost { get; set; }
        public decimal QtyList { get; set; }
        public int FKPosType { get; set; }
        public int FKPosMachine { get; set; }
        public int FKBudgetYear { get; set; }
        public int PrintSequence { get; set; }
        public Nullable<int> FKDebtorPaymentDetails { get; set; }
    
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CNHeader> CNHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebtorPaymentDetails> DebtorPaymentDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RePrintReceiptLog> RePrintReceiptLog { get; set; }
        public virtual Debtor Debtor { get; set; }
        public virtual Member Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosDetails> PosDetails { get; set; }
        public virtual PosMachine PosMachine { get; set; }
        public virtual PosType PosType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosPromotion> PosPromotion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosUsedPromotion> PosUsedPromotion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrintSlipLog> PrintSlipLog { get; set; }
    }
}