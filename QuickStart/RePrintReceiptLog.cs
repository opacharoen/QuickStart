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
    
    public partial class RePrintReceiptLog
    {
        public int Id { get; set; }
        public bool Enable { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public int FKReceiptAddress { get; set; }
        public bool IsOriginal { get; set; }
        public int FKPosHeader { get; set; }
        public int OriginalSequence { get; set; }
        public int CopySequence { get; set; }
    
        public virtual PosHeader PosHeader { get; set; }
        public virtual ReceiptAddress ReceiptAddress { get; set; }
    }
}
