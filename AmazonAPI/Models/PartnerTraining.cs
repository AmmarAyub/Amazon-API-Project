using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PartnerTraining
{
    public int TrainingId { get; set; }

    public int? PartnerId { get; set; }

    public string TrainingName { get; set; } = null!;

    public string? TrainingType { get; set; }

    public DateOnly? CompletionDate { get; set; }

    public bool? CertIssuedTo { get; set; }

    public bool? CertificateUploaded { get; set; }

    public virtual Partner? Partner { get; set; }

    public virtual ICollection<PartnerCertificate> PartnerCertificates { get; set; } = new List<PartnerCertificate>();
}
