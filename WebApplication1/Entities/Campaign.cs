using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Campaign
    {
        public Guid Id { get; set; }
        public int Status { get; set; }
        public bool IsVisibleOnClientCampaignsPage { get; set; }
        public Guid? GroupId { get; set; }
        public Guid? MasterProductId { get; set; }
        public Guid? BrandId { get; set; }
        public Guid? CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Type { get; set; }
        public int? DiscountType { get; set; }
        public decimal? PercentageOfDiscount { get; set; }
        public decimal? AmountOfDiscount { get; set; }
        public decimal? AmountOfAppliedDiscount { get; set; }
        public bool? IsForAllProducts { get; set; }
        public string ImageUrl { get; set; }
        public string SeoTitle { get; set; }
        public string SeoKeywords { get; set; }
        public string SeoDescription { get; set; }
        public decimal? MinimumAmount { get; set; }
        public decimal? MaximumAmount { get; set; }
        public int? MinimumCount { get; set; }
        public int? MaximumCount { get; set; }
        public bool ShouldRounding { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
        public string Url { get; set; }
    }
}
