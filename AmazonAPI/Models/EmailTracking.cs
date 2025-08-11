using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class EmailTracking
{
    public Guid EmailId { get; set; }

    public int? DocumentId { get; set; }

    public int? DocumentType { get; set; }

    public string? EmailSubject { get; set; }

    public string? EmailMessage { get; set; }

    public bool? Isviewed { get; set; }

    public DateOnly? EmailDate { get; set; }

    public DateOnly? IsViewedDate { get; set; }

    public virtual Form? DocumentTypeNavigation { get; set; }

    public virtual ICollection<EmailCclist> EmailCclists { get; set; } = new List<EmailCclist>();

    public virtual ICollection<EmailToList> EmailToLists { get; set; } = new List<EmailToList>();
}
