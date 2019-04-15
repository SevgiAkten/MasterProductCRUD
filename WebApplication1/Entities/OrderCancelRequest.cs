using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class OrderCancelRequest
    {
        public Guid Id { get; set; }
        public Guid? OrderId { get; set; }
        public Guid? OrderCancelRequestReasonId { get; set; }
        public string Description { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsRefunded { get; set; }
        public string Result { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public string ModifiedIp { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedAdusername { get; set; }
        public int AutoId { get; set; }
    }
}
