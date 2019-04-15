using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Coupon
    {
        public Guid Id { get; set; }
        public int Status { get; set; }
        public string Code { get; set; }
        public Guid CampaignId { get; set; }
        public Guid? ReserverUserId { get; set; }
        public Guid? UserUserId { get; set; }
        public bool IsUsed { get; set; }
        public int OrderIndex { get; set; }
        public int? MaxUsageCountPerUser { get; set; }
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
