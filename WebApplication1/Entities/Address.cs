using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Address
    {
        public Guid Id { get; set; }
        public Guid? MasterAddressId { get; set; }
        public int? MikroId { get; set; }
        public string AddressContent { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string Phone { get; set; }
        public string PostCode { get; set; }
        public Guid AddressHeaderId { get; set; }
        public Guid CityId { get; set; }
        public Guid CountyId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? PersonelInformationId { get; set; }
        public string FullTextAddress { get; set; }
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public bool? IsCorporate { get; set; }
        public int Status { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedAduserName { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public int AutoId { get; set; }

        public AddressHeader AddressHeader { get; set; }
        public City City { get; set; }
        public County County { get; set; }
    }
}
