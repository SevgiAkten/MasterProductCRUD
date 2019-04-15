using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class OrderActivityType
    {
        public Guid Id { get; set; }
        public Guid? MasterOrderActivityTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsEditable { get; set; }
        public bool? IsPublic { get; set; }
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
