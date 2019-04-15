using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class EntityType
    {
        public EntityType()
        {
            SlugInfo = new HashSet<SlugInfo>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsMenuable { get; set; }
        public string RoutingController { get; set; }
        public string RoutingAction { get; set; }
        public string RedirectController { get; set; }
        public string RedirectAction { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public ICollection<SlugInfo> SlugInfo { get; set; }
    }
}
