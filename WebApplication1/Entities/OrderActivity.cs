using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class OrderActivity
    {
        public Guid Id { get; set; }
        public Guid? ActivityTypeId { get; set; }
        public Guid? OrderId { get; set; }
        public Guid? OrderItemId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ActivityDate { get; set; }
        public bool? IsPublic { get; set; }
        public string Description { get; set; }
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
