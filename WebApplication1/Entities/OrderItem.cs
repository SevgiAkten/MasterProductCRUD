using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class OrderItem
    {
        public Guid Id { get; set; }
        public int? MikroId { get; set; }
        public Guid OrderId { get; set; }
        public Guid? ProductId { get; set; }
        public string StockCode { get; set; }
        public Guid? ShoppingCartItemId { get; set; }
        public Guid? MasterProductId { get; set; }
        public decimal? Price { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountAmountPercentage { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? TotalSalesPrice { get; set; }
        public decimal? TotalProductPrice { get; set; }
        public decimal? TotalDiscountAmount { get; set; }
        public decimal? TotalDiscountAmountPercentage { get; set; }
        public string ProductName { get; set; }
        public Guid? Vatid { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Vatamount { get; set; }
        public Guid? CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int? SequenceNumber { get; set; }
        public string ShippingCode { get; set; }
        public string ShippingLink { get; set; }
        public int? ShippingStatus { get; set; }
        public int? OrderItemStatus { get; set; }
        public string CargoNumber { get; set; }
        public int? CreatedByTransactionType { get; set; }
        public int? Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public Order Order { get; set; }
    }
}
