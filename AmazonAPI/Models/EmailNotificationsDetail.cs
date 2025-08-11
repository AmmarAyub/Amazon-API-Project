using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class EmailNotificationsDetail
{
    public Guid EmailNotificationsDetailsId { get; set; }

    public Guid EmailNotificationId { get; set; }

    public string? Subject { get; set; }

    public string? BodyTitle { get; set; }

    public string? Body { get; set; }

    public int? EmployeeId { get; set; }

    public string? EmailAddress { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual Employee? Employee { get; set; }
}
