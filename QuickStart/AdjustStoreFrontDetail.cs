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
    
    public partial class AdjustStoreFrontDetail
    {
        public int Id { get; set; }
        public bool Enable { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string FKAdjustStoreFront { get; set; }
        public int FKProductDetails { get; set; }
        public decimal Qty { get; set; }
        public decimal CostPerUnit { get; set; }
        public decimal SellPricePerUnit { get; set; }
    
        public virtual AdjustStoreFront AdjustStoreFront { get; set; }
        public virtual ProductDetails ProductDetails { get; set; }
    }
}
