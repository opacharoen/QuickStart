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
    
    public partial class WmsStockDetail
    {
        public int Id { get; set; }
        public int FKItemRemark { get; set; }
        public int FKProductDetail { get; set; }
        public int FKTransaction { get; set; }
        public int FKWmsStock { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public bool Enable { get; set; }
        public string Description { get; set; }
        public decimal PackSize { get; set; }
        public decimal ActionQty { get; set; }
        public decimal ActionQtyUnit { get; set; }
        public decimal ResultQty { get; set; }
        public decimal ResultQtyUnit { get; set; }
        public decimal OldQty { get; set; }
    
        public virtual ItemRemark ItemRemark { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
        public virtual TransactionWms TransactionWms { get; set; }
        public virtual WmsStock WmsStock { get; set; }
    }
}
