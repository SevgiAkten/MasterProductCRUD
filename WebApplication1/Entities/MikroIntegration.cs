using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class MikroIntegration
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public int UserId { get; set; }
        public int? MikroUserId { get; set; }
        public int AddressId { get; set; }
        public int? MikroAddressId { get; set; }
        public int OrderItemId { get; set; }
        public int? MikroOrderItemId { get; set; }
        public int BillingAddressId { get; set; }
        public int? MikroBillingAddressId { get; set; }
        public int OrderId { get; set; }
        public string CurrentCode { get; set; }
        public string UserFullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int SequenceNumber { get; set; }
        public string StockCode { get; set; }
        public double TotalPrice { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double? VatRatio { get; set; }
        public double Kdvamount { get; set; }
        public double DiscountPrice { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Avenue { get; set; }
        public string Street { get; set; }
        public string BillingCity { get; set; }
        public string BillingCounty { get; set; }
        public string BillingAvenue { get; set; }
        public string BillingStreet { get; set; }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public bool? IsCorporate { get; set; }
        public bool IsIntegrated { get; set; }
        public int? NumberOfAttempts { get; set; }
        public int Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }
    }
}
