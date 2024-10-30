using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DbFirst.Models
{
    public partial class Crm04
    {
        public long? LotNum { get; set; }
        public long PolicyNo { get; set; }
        public string PolicyNumber { get; set; }
        public string ProposalNumber { get; set; }
        public string Policyholder { get; set; }
        public string FirstName { get; set; }
        public decimal? SumInsured { get; set; }
        public decimal? PremiumAmount { get; set; }
        public long Crncy { get; set; }
        public string Dob { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Occupation { get; set; }
        public DateTime? InceptionDate { get; set; }
        public DateTime? MaaturityDate { get; set; }
        public DateTime? DateTermination { get; set; }
        public DateTime? DateRenewal { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public string CustomerId { get; set; }
        public long? CompCode { get; set; }
        public string Business { get; set; }
        public string PaymentFrequency { get; set; }
        public string Marketer { get; set; }
        public string MarketerCode { get; set; }
        public string UnitName { get; set; }
        public string Code { get; set; }
        public string CustomerType { get; set; }
        public string BusinessType { get; set; }
        public long? PartnerPartnerId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime RefreshDate { get; set; }
    }
}
