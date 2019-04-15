using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PageLog
    {
        public Guid Id { get; set; }
        public string Slug { get; set; }
        public Guid? SessionId { get; set; }
        public Guid? UserId { get; set; }
        public string Ref { get; set; }
        public string Query { get; set; }
        public Guid? EntityId { get; set; }
        public Guid? EntityTypeId { get; set; }
        public int? SlugType { get; set; }
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
