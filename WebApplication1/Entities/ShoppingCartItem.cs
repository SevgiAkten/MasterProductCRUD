using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ShoppingCartItem
    {
        public Guid Id { get; set; }
        public Guid MasterProductId { get; set; }
        public Guid ShoppingCartId { get; set; }
        public int? Quantity { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
        public Guid? ProductId { get; set; }

        public MasterProduct MasterProduct { get; set; }
        public Product Product { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
