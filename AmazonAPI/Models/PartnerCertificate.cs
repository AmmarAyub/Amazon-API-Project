using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class PartnerCertificate
{
    public int CertificateId { get; set; }

    public int? TrainingId { get; set; }

    public string? CertificateName { get; set; }

    public string? CertificateNumber { get; set; }

    public string? IssuedToName { get; set; }

    public string? CertificateDescription { get; set; }

    public byte[]? CertificateFile { get; set; }

    public DateOnly? UploadDate { get; set; }

    public virtual PartnerTraining? Training { get; set; }
}
