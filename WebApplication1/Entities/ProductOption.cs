using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ProductOption
    {
        public ProductOption()
        {
            ProductOptionValue = new HashSet<ProductOptionValue>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public ICollection<ProductOptionValue> ProductOptionValue { get; set; }
    }
}
