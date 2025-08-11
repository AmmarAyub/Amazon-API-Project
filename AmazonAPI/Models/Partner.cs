using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Partner
{
    public int PartnerId { get; set; }

    public string? PartnerShipType { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Title { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? Website { get; set; }

    public string? Industry { get; set; }

    public int? ContactCompanyId { get; set; }

    public bool? Renewal { get; set; }

    public decimal? MinDealValue { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public string? Notes { get; set; }

    public string? ChangedBy { get; set; }

    public DateTime? ChangeDate { get; set; }

    public virtual ContactCompany? ContactCompany { get; set; }

    public virtual ICollection<PartnerContact> PartnerContacts { get; set; } = new List<PartnerContact>();

    public virtual ICollection<PartnerLogin> PartnerLogins { get; set; } = new List<PartnerLogin>();

    public virtual ICollection<PartnerOpportunity> PartnerOpportunities { get; set; } = new List<PartnerOpportunity>();

    public virtual ICollection<PartnerTraining> PartnerTrainings { get; set; } = new List<PartnerTraining>();
}
