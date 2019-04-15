using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ProductTag
    {
        public Guid Id { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
        public Guid ProductId { get; set; }
        public Guid TagId { get; set; }

        public MasterProduct Product { get; set; }
        public Tag Tag { get; set; }
    }
}
