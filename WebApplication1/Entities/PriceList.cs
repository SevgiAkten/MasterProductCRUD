using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PriceList
    {
        public Guid Id { get; set; }
        public Guid MasterProductId { get; set; }
        public decimal ListPrice { get; set; }
        public decimal SalesPrice { get; set; }
        public double? Vat { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? SalesVatAmount { get; set; }
        public Guid? CampaignId { get; set; }
        public string CampaignName { get; set; }
        public DateTime? CampaignStartDate { get; set; }
        public DateTime? CampaignEndDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
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
