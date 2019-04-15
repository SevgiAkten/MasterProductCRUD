using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class SlugInfo
    {
        public SlugInfo()
        {
            InverseRedirectSlugInfo = new HashSet<SlugInfo>();
            MasterProduct = new HashSet<MasterProduct>();
            Menu = new HashSet<Menu>();
            MenuOld = new HashSet<MenuOld>();
        }

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
        public int EntityId { get; set; }
        public string Slug { get; set; }
        public Guid EntityTypeId { get; set; }
        public Guid? RedirectSlugInfoId { get; set; }

        public EntityType EntityType { get; set; }
        public SlugInfo RedirectSlugInfo { get; set; }
        public ICollection<SlugInfo> InverseRedirectSlugInfo { get; set; }
        public ICollection<MasterProduct> MasterProduct { get; set; }
        public ICollection<Menu> Menu { get; set; }
        public ICollection<MenuOld> MenuOld { get; set; }
    }
}
