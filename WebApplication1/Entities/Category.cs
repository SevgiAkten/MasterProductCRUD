using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryCategoryCategory = new HashSet<CategoryCategory>();
            CategoryCategoryMasterCategory = new HashSet<CategoryCategory>();
            MasterProduct = new HashSet<MasterProduct>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrderIndex { get; set; }
        public int? MaximumLegalInstallment { get; set; }
        public decimal? MinumumInstallmentPrice { get; set; }
        public int? Status { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public double? Desi { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAdusername { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
        public Guid? ProductTemplateId { get; set; }
        public bool IsLastLevel { get; set; }

        public ProductTemplate ProductTemplate { get; set; }
        public ICollection<CategoryCategory> CategoryCategoryCategory { get; set; }
        public ICollection<CategoryCategory> CategoryCategoryMasterCategory { get; set; }
        public ICollection<MasterProduct> MasterProduct { get; set; }
    }
}
