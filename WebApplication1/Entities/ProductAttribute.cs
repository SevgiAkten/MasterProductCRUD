using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ProductAttribute
    {
        public ProductAttribute()
        {
            ProductAttributeSelection = new HashSet<ProductAttributeSelection>();
            ProductAttributeValue = new HashSet<ProductAttributeValue>();
            ProductTemplateProductAttribute = new HashSet<ProductTemplateProductAttribute>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? GroupId { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public ProductAttributeGroup Group { get; set; }
        public ICollection<ProductAttributeSelection> ProductAttributeSelection { get; set; }
        public ICollection<ProductAttributeValue> ProductAttributeValue { get; set; }
        public ICollection<ProductTemplateProductAttribute> ProductTemplateProductAttribute { get; set; }
    }
}
