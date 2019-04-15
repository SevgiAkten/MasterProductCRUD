using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            MasterProduct = new HashSet<MasterProduct>();
            SupplierBrand = new HashSet<SupplierBrand>();
            User = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public Guid? CompanyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid OfficialUserId { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public ICollection<MasterProduct> MasterProduct { get; set; }
        public ICollection<SupplierBrand> SupplierBrand { get; set; }
        public ICollection<User> User { get; set; }
    }
}
