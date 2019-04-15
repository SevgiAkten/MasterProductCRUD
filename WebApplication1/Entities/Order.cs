using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public Guid? PersonelInformationId { get; set; }
        public int? PersonalInformationAutoId { get; set; }
        public string PersonalInformationCurrentCode { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string DeliveryAddress { get; set; }
        public Guid? DeliveryCityId { get; set; }
        public Guid? DeliveryCountyId { get; set; }
        public int? OrderStatus { get; set; }
        public int TableIntegrationStatus { get; set; }
        public int Status { get; set; }
        public Guid? ShoppingCartId { get; set; }
        public Guid? ShippingCountryId { get; set; }
        public Guid? ShippingCityId { get; set; }
        public Guid? ShippingCountyId { get; set; }
        public Guid? ShippingAddressId { get; set; }
        public int? ShippingAddressAutoId { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingCityName { get; set; }
        public string ShippingCountyName { get; set; }
        public string ShippingAddressContent { get; set; }
        public string ShippingFirstName { get; set; }
        public string ShippingLastName { get; set; }
        public string ShippingPhone { get; set; }
        public string ShippingCompanyName { get; set; }
        public string ShippingTaxNumber { get; set; }
        public string ShippingTaxOffice { get; set; }
        public bool? ShippingCompanyIsCorporate { get; set; }
        public Guid? BillingCountryId { get; set; }
        public Guid? BillingCityId { get; set; }
        public Guid? BillingCountyId { get; set; }
        public Guid? BillingAddressId { get; set; }
        public int? BillingAddressAutoId { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCityName { get; set; }
        public string BillingCountyName { get; set; }
        public string BillingAddressContent { get; set; }
        public string BillingFirstName { get; set; }
        public string BillingLastName { get; set; }
        public string BillingPhone { get; set; }
        public string BillingCompanyName { get; set; }
        public Guid? BillingCompanyPersonalInformationId { get; set; }
        public int? BillingCompanyPersonalInformationAutoId { get; set; }
        public string BillingTaxNumber { get; set; }
        public string BillingTaxOffice { get; set; }
        public bool? BillingCompanyIsCorporate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PaymentCode { get; set; }
        public decimal? PaidPrice { get; set; }
        public int? Installment { get; set; }
        public int? MaxInstallmentCount { get; set; }
        public decimal? PaymentPrice { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentLink { get; set; }
        public DateTime? PaymentExpire { get; set; }
        public string MaskedCardNumber { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? TotalSalesPrice { get; set; }
        public decimal? TotalProductPrice { get; set; }
        public decimal? TotalProductDiscountAmount { get; set; }
        public decimal? TotalProductDiscountPercentage { get; set; }
        public decimal? PaymentShippingPrice { get; set; }
        public decimal? ShippingPrice { get; set; }
        public Guid? CampaignId { get; set; }
        public string CampaignName { get; set; }
        public Guid? ShippingCampaignId { get; set; }
        public string ShippingCampaignName { get; set; }
        public decimal? CouponDiscountAmount { get; set; }
        public string CouponCode { get; set; }
        public decimal? Vatamount { get; set; }
        public decimal? TotalDiscountAmount { get; set; }
        public decimal? TotalDiscountPercentage { get; set; }
        public int? TotalItemQuantity { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime? DeliveringDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public ICollection<OrderItem> OrderItem { get; set; }
    }
}
