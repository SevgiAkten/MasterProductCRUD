using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Brand
    {
        public Brand()
        {
            MasterProduct = new HashSet<MasterProduct>();
            SupplierBrand = new HashSet<SupplierBrand>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public string WebSiteUrl { get; set; }
        public int? Status { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public ICollection<MasterProduct> MasterProduct { get; set; }
        public ICollection<SupplierBrand> SupplierBrand { get; set; }
    }
}
