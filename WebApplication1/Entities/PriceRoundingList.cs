using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PriceRoundingList
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public decimal MinimumSalesPrice { get; set; }
        public decimal MaximumSalesPrice { get; set; }
        public decimal RoundedPrice { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public string ModifiedIp { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedAdusername { get; set; }
        public int AutoId { get; set; }
    }
}
