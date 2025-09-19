using System.ComponentModel.DataAnnotations;

namespace AmazonAPI.Models.DTO_s
{
    public class PartnerCreateDto
    {
        [Required]
        public string PartnerShipType { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        [Url]
        public string Website { get; set; }

        public string Industry { get; set; }
        public int? ContactCompanyID { get; set; }
        public bool? Renewal { get; set; }
        public decimal? MinDealValue { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Notes { get; set; }
        public string ChangedBy { get; set; }
        public DateTime ChangeDate { get; set; }
    }

    public class PartnerEditDataDto
    {
        public Partner Partner { get; set; }
        public List<ContactCompany> ContactCompanies { get; set; }
        public List<PartnerContact> Contacts { get; set; }
        public int ContactCount { get; set; }
        public List<PartnerTraining> Trainings { get; set; }
        public int TrainingCount { get; set; }
        public List<PartnerOpportunity> Opportunities { get; set; }
        public int OpportunityCount { get; set; }
        public List<PartnerLogin> Logins { get; set; }
        public int LoginCount { get; set; }
    }

    public class PartnerUpdateDto
    {
        public int PartnerID { get; set; }

        [Required]
        public string PartnerShipType { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        [Url]
        public string Website { get; set; }

        public string Industry { get; set; }
        public int? ContactCompanyID { get; set; }
        public bool? Renewal { get; set; }
        public decimal? MinDealValue { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string Notes { get; set; }
        public string ChangedBy { get; set; }
        public DateTime ChangeDate { get; set; }
    }

    public class ApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int? Id { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }

    public class PartnerModel
    {
        public int PartnerID { get; set; }
        public string PartnerShipType { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Website { get; set; }
        public string Industry { get; set; }
        public int? ContactCompanyID { get; set; }
        public bool Renewal { get; set; }
        public decimal? MinDealValue { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Notes { get; set; }
        public string ChangedBy { get; set; }
        public DateTime ChangeDate { get; set; }
    }

    public class PartnerContactModel
    {
        public int ContactID { get; set; }
        public int PartnerID { get; set; }
        public string ContactName { get; set; }
        public string AddressLine1 { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string ContactRole { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string PostalCode { get; set; }
        public string Notes { get; set; }
    }

    public class PartnerTrainingModel
    {
        public int TrainingID { get; set; }
        public int PartnerID { get; set; }
        public string TrainingName { get; set; }
        public string TrainingType { get; set; }
        public DateTime? CompletionDate { get; set; } // Changed from DateOnly to DateTime
        public bool? CertIssuedTo { get; set; }
        public bool CertificateUploaded { get; set; }
    }

    public class PartnerOpportunityModel
    {
        public int OpportunityID { get; set; }
        public int PartnerID { get; set; }
        public string OpportunityName { get; set; }
        public string OpportunityType { get; set; }
        public string ProductName { get; set; }
        public string SerialNumber { get; set; }
        public string FortiCareID { get; set; }
        public string CoTermQuoteID { get; set; }
        public string TradeUpID { get; set; }
        public bool IsSDWANOpportunity { get; set; }
        public string IsOperationalTechnologyOpportunity { get; set; }
        public decimal EstimatedValue { get; set; }
        public int StatusID { get; set; }
        public bool DealRegOOT { get; set; }
        public bool IsRenewalOver9999 { get; set; }
        public bool FedDeal { get; set; }
        public bool TradeIn { get; set; }
        public string DealType { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string ChangedBy { get; set; }
    }

    public class PartnerLoginModel
    {
        public int LoginID { get; set; }
        public int PartnerID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoginURL { get; set; }
    }

    public class PartnerTrainingDto
    {
        public int TrainingID { get; set; }
        public int? PartnerID { get; set; }
        public string PartnerName { get; set; }

        [Required]
        [StringLength(100)]
        public string TrainingName { get; set; }

        [StringLength(50)]
        public string TrainingType { get; set; }

        public DateTime? CompletionDate { get; set; } // Changed from DateOnly to DateTime

        public bool? CertIssuedTo { get; set; }

        public bool? CertificateUploaded { get; set; }
    }

    public class PartnerTrainingCreateDto
    {
        [Required]
        public int PartnerID { get; set; }

        [Required]
        [StringLength(100)]
        public string TrainingName { get; set; }

        [StringLength(50)]
        public string TrainingType { get; set; }

        public DateOnly? CompletionDate { get; set; } // Changed from DateOnly to DateTime

        public bool? CertIssuedTo { get; set; }

        public bool CertificateUploaded { get; set; }
    }

    public class PartnerTrainingUpdateDto
    {
        public int TrainingID { get; set; }

        [Required]
        public int PartnerID { get; set; }

        [Required]
        [StringLength(100)]
        public string TrainingName { get; set; }

        [StringLength(50)]
        public string TrainingType { get; set; }

        public DateOnly? CompletionDate { get; set; } // Changed from DateOnly to DateTime

        public bool? CertIssuedTo { get; set; }

        public bool CertificateUploaded { get; set; }
    }

    public class PartnerDropdownDto
    {
        public int PartnerID { get; set; }
        public string Name { get; set; }
    }
}