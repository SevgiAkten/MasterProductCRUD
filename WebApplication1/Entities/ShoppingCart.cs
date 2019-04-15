using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class ShoppingCart
    {
        public ShoppingCart()
        {
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
        }

        public Guid Id { get; set; }
        public Guid SessionId { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal? CouponDiscountPercent { get; set; }
        public decimal? CouponDiscountAmount { get; set; }
        public decimal? TotalPriceAfterCouponDiscount { get; set; }
        public Guid? CouponCampaignId { get; set; }
        public string CouponCode { get; set; }
        public bool? IsCouponDiscountActive { get; set; }
        public decimal? CouponCodeMinimumAmount { get; set; }
        public int TotalProducts { get; set; }
        public Guid? UserId { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public Session Session { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
    }
}
