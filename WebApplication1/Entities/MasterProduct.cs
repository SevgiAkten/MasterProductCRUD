using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class MasterProduct
    {
        public MasterProduct()
        {
            ExcelImportedProduct = new HashSet<ExcelImportedProduct>();
            Product = new HashSet<Product>();
            ProductAttributeValue = new HashSet<ProductAttributeValue>();
            ProductComment = new HashSet<ProductComment>();
            ProductDiscount = new HashSet<ProductDiscount>();
            ProductFile = new HashSet<ProductFile>();
            ProductGroup = new HashSet<ProductGroup>();
            ProductTag = new HashSet<ProductTag>();
            RelatedProductProduct = new HashSet<RelatedProduct>();
            RelatedProductRelatedProductNavigation = new HashSet<RelatedProduct>();
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public int? MinimumOrder { get; set; }
        public int LeadTime { get; set; }
        public int ShiploadTime { get; set; }
        public string LogisticType { get; set; }
        public decimal MainPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public double Discount { get; set; }
        public int? MaximumLegalInstallment { get; set; }
        public decimal? MinumumInstallmentPrice { get; set; }
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
        public bool? HasStock { get; set; }
        public double? Desi { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
        public int CriticalStock { get; set; }
        public decimal? FakePrice { get; set; }

        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public Sector Sector { get; set; }
        public SlugInfo SlugInfo { get; set; }
        public Supplier Supplier { get; set; }
        public Tax Tax { get; set; }
        public UnitType UnitType { get; set; }
        public Vat Vat { get; set; }
        public Stock Stock { get; set; }
        public ICollection<ExcelImportedProduct> ExcelImportedProduct { get; set; }
        public ICollection<Product> Product { get; set; }
        public ICollection<ProductAttributeValue> ProductAttributeValue { get; set; }
        public ICollection<ProductComment> ProductComment { get; set; }
        public ICollection<ProductDiscount> ProductDiscount { get; set; }
        public ICollection<ProductFile> ProductFile { get; set; }
        public ICollection<ProductGroup> ProductGroup { get; set; }
        public ICollection<ProductTag> ProductTag { get; set; }
        public ICollection<RelatedProduct> RelatedProductProduct { get; set; }
        public ICollection<RelatedProduct> RelatedProductRelatedProductNavigation { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
    }
}
