using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public int? MikroId { get; set; }
        public string UserName { get; set; }
        public string CurrentCode { get; set; }
        public Guid? SupplierId { get; set; }
        public Guid? McUserId { get; set; }
        public bool? IsMasterUser { get; set; }
        public int? Status { get; set; }
        public int SpamStatus { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public Supplier Supplier { get; set; }
    }
}
