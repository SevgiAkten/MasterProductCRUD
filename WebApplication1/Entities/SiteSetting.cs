using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class SiteSetting
    {
        public Guid Id { get; set; }
        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeywords { get; set; }
        public string FacebookUsername { get; set; }
        public string TwitterUsername { get; set; }
        public string InstagramUsername { get; set; }
        public decimal? MinimumAmountForInstallment { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public string ModifiedAdusername { get; set; }
        public int AutoId { get; set; }
    }
}
