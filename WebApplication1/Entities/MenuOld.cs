using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class MenuOld
    {
        public MenuOld()
        {
            InverseParent = new HashSet<MenuOld>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
        public Guid? ParentId { get; set; }
        public Guid? SlugInfoId { get; set; }

        public MenuOld Parent { get; set; }
        public SlugInfo SlugInfo { get; set; }
        public ICollection<MenuOld> InverseParent { get; set; }
    }
}
