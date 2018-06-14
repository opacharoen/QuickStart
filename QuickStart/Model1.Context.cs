﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SSLsEntities : DbContext
    {
        public SSLsEntities()
            : base("name=SSLsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuAccess> MenuAccess { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<CNCancel> CNCancel { get; set; }
        public virtual DbSet<CNDetails> CNDetails { get; set; }
        public virtual DbSet<CNHeader> CNHeader { get; set; }
        public virtual DbSet<CNType> CNType { get; set; }
        public virtual DbSet<DebtorPaymentDetails> DebtorPaymentDetails { get; set; }
        public virtual DbSet<EmpHasPosition> EmpHasPosition { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<MemberDividendEarning> MemberDividendEarning { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<RePrintReceiptLog> RePrintReceiptLog { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Debtor> Debtor { get; set; }
        public virtual DbSet<DebtorPayment> DebtorPayment { get; set; }
        public virtual DbSet<AgeOfShare> AgeOfShare { get; set; }
        public virtual DbSet<Meeting> Meeting { get; set; }
        public virtual DbSet<MeetingSchedule> MeetingSchedule { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<MemberChangeMoney2560> MemberChangeMoney2560 { get; set; }
        public virtual DbSet<MemberShare> MemberShare { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<Share> Share { get; set; }
        public virtual DbSet<SaleOrderWarehouse> SaleOrderWarehouse { get; set; }
        public virtual DbSet<SaleOrderWarehouseDtl> SaleOrderWarehouseDtl { get; set; }
        public virtual DbSet<SaleOrderWarehouseStatus> SaleOrderWarehouseStatus { get; set; }
        public virtual DbSet<AdjustStoreFront> AdjustStoreFront { get; set; }
        public virtual DbSet<AdjustStoreFrontDetail> AdjustStoreFrontDetail { get; set; }
        public virtual DbSet<BudgetYear> BudgetYear { get; set; }
        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<CheckStockDetails> CheckStockDetails { get; set; }
        public virtual DbSet<CheckStockPos> CheckStockPos { get; set; }
        public virtual DbSet<CostDtlChangeLog> CostDtlChangeLog { get; set; }
        public virtual DbSet<CostType> CostType { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DeliveryType> DeliveryType { get; set; }
        public virtual DbSet<GetGoodsStoreFront> GetGoodsStoreFront { get; set; }
        public virtual DbSet<GetGoodsStoreFrontDetails> GetGoodsStoreFrontDetails { get; set; }
        public virtual DbSet<ISS2Front> ISS2Front { get; set; }
        public virtual DbSet<ISS2FrontDetails> ISS2FrontDetails { get; set; }
        public virtual DbSet<ISS2FrontStatus> ISS2FrontStatus { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<POCostType> POCostType { get; set; }
        public virtual DbSet<PODetail> PODetail { get; set; }
        public virtual DbSet<POGenerate> POGenerate { get; set; }
        public virtual DbSet<POHeader> POHeader { get; set; }
        public virtual DbSet<PORcv> PORcv { get; set; }
        public virtual DbSet<PORcvCash> PORcvCash { get; set; }
        public virtual DbSet<PORcvCashDetails> PORcvCashDetails { get; set; }
        public virtual DbSet<PORcvDetails> PORcvDetails { get; set; }
        public virtual DbSet<PosDetails> PosDetails { get; set; }
        public virtual DbSet<PosGenerateCode> PosGenerateCode { get; set; }
        public virtual DbSet<PosHeader> PosHeader { get; set; }
        public virtual DbSet<PosMachine> PosMachine { get; set; }
        public virtual DbSet<PosPromotion> PosPromotion { get; set; }
        public virtual DbSet<PosStock> PosStock { get; set; }
        public virtual DbSet<PosStockDetails> PosStockDetails { get; set; }
        public virtual DbSet<POStatus> POStatus { get; set; }
        public virtual DbSet<PosType> PosType { get; set; }
        public virtual DbSet<PriceSchedule> PriceSchedule { get; set; }
        public virtual DbSet<PriceScheduleCheck> PriceScheduleCheck { get; set; }
        public virtual DbSet<PrintSlipLog> PrintSlipLog { get; set; }
        public virtual DbSet<ProcessedGoods> ProcessedGoods { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductColor> ProductColor { get; set; }
        public virtual DbSet<ProductPosCollectPoints> ProductPosCollectPoints { get; set; }
        public virtual DbSet<ProductSize> ProductSize { get; set; }
        public virtual DbSet<ProductVatType> ProductVatType { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<RcvInvoice> RcvInvoice { get; set; }
        public virtual DbSet<ReceiptAddress> ReceiptAddress { get; set; }
        public virtual DbSet<SellingPrice> SellingPrice { get; set; }
        public virtual DbSet<SellingPriceDetails> SellingPriceDetails { get; set; }
        public virtual DbSet<SellPriceChangeLog> SellPriceChangeLog { get; set; }
        public virtual DbSet<Shelf> Shelf { get; set; }
        public virtual DbSet<StoreFrontStock> StoreFrontStock { get; set; }
        public virtual DbSet<StoreFrontStockDetails> StoreFrontStockDetails { get; set; }
        public virtual DbSet<StoreFrontStockDetails1310> StoreFrontStockDetails1310 { get; set; }
        public virtual DbSet<StoreFrontStockDetails161017> StoreFrontStockDetails161017 { get; set; }
        public virtual DbSet<StoreFrontStockDetailsForUpdate> StoreFrontStockDetailsForUpdate { get; set; }
        public virtual DbSet<StoreFrontTransferOut> StoreFrontTransferOut { get; set; }
        public virtual DbSet<StoreFrontTransferOutDtl> StoreFrontTransferOutDtl { get; set; }
        public virtual DbSet<StoreFrontTransferWaste> StoreFrontTransferWaste { get; set; }
        public virtual DbSet<StoreFrontTransferWasteDtl> StoreFrontTransferWasteDtl { get; set; }
        public virtual DbSet<StoreFrontValueDoc> StoreFrontValueDoc { get; set; }
        public virtual DbSet<StoreFrontValueSet> StoreFrontValueSet { get; set; }
        public virtual DbSet<TransactionType> TransactionType { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<VatType> VatType { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<WasteReason> WasteReason { get; set; }
        public virtual DbSet<CNWarehouse> CNWarehouse { get; set; }
        public virtual DbSet<CNWarehouseDetails> CNWarehouseDetails { get; set; }
        public virtual DbSet<CostProductChangeLog> CostProductChangeLog { get; set; }
        public virtual DbSet<CurrentStocks> CurrentStocks { get; set; }
        public virtual DbSet<ItemRemark> ItemRemark { get; set; }
        public virtual DbSet<ItemStatus> ItemStatus { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<LocationType> LocationType { get; set; }
        public virtual DbSet<PickingDetails> PickingDetails { get; set; }
        public virtual DbSet<PickingLocation> PickingLocation { get; set; }
        public virtual DbSet<Pickings> Pickings { get; set; }
        public virtual DbSet<PickingType> PickingType { get; set; }
        public virtual DbSet<ProductBrands> ProductBrands { get; set; }
        public virtual DbSet<ProductDetails> ProductDetails { get; set; }
        public virtual DbSet<ProductGroups> ProductGroups { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductUnit> ProductUnit { get; set; }
        public virtual DbSet<RcvDetails> RcvDetails { get; set; }
        public virtual DbSet<RcvHeader> RcvHeader { get; set; }
        public virtual DbSet<RcvLocation> RcvLocation { get; set; }
        public virtual DbSet<RcvType> RcvType { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<TransactionWms> TransactionWms { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WarehouseToWaste> WarehouseToWaste { get; set; }
        public virtual DbSet<WarehouseToWasteDetails> WarehouseToWasteDetails { get; set; }
        public virtual DbSet<WasteWarehouse> WasteWarehouse { get; set; }
        public virtual DbSet<WasteWarehouseDetails> WasteWarehouseDetails { get; set; }
        public virtual DbSet<WmsStock> WmsStock { get; set; }
        public virtual DbSet<WmsStockDetail> WmsStockDetail { get; set; }
        public virtual DbSet<WmsTransferOut> WmsTransferOut { get; set; }
        public virtual DbSet<WmsTransferOutDetails> WmsTransferOutDetails { get; set; }
        public virtual DbSet<Zone> Zone { get; set; }
        public virtual DbSet<PosUsedPromotion> PosUsedPromotion { get; set; }
    }
}
