using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ShippingCompanyPrice
    {
        public Guid Id { get; set; }
        public int? MinDesi { get; set; }
        public int? MaxDesi { get; set; }
        public decimal? Price { get; set; }
        public Guid? ShippingCompanyId { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedIp { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public int AutoId { get; set; }
    }
}
