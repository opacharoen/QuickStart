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
    
    public partial class WmsTransferOutDetails
    {
        public int Id { get; set; }
        public bool Enable { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public string FKWmsTransferOut { get; set; }
        public int FKProductDetails { get; set; }
        public decimal Qty { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal BeforeVat { get; set; }
        public decimal Vat { get; set; }
        public decimal TotalPrice { get; set; }
    
        public virtual ProductDetails ProductDetails { get; set; }
        public virtual WmsTransferOut WmsTransferOut { get; set; }
    }
}
