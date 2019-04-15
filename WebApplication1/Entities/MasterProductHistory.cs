using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class MasterProductHistory
    {
        public Guid Id { get; set; }
        public Guid MasterId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int? MinimumOrder { get; set; }
        public int LeadTime { get; set; }
        public int ShiploadTime { get; set; }
        public string LogisticType { get; set; }
        public decimal? MainPrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public double Discount { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Depth { get; set; }
        public double? Weight { get; set; }
        public string StockCode { get; set; }
        public Guid? BrandId { get; set; }
        public Guid? VatId { get; set; }
        public Guid? UnitTypeId { get; set; }
        public Guid? SectorId { get; set; }
        public int? Stage { get; set; }
        public string WorkflowMessage { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? SlugInfoId { get; set; }
        public double? BoxWidth { get; set; }
        public double? BoxHeight { get; set; }
        public double? BoxDepth { get; set; }
        public double? BoxWeight { get; set; }
        public double? PackageWidth { get; set; }
        public double? PackageHeight { get; set; }
        public double? PackageDepth { get; set; }
        public double? PackageWeight { get; set; }
        public Guid? TaxId { get; set; }
        public Guid? UserId { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
    }
}
