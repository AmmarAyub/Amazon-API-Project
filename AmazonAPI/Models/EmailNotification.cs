using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class EmailNotification
{
    public Guid EmailNotificationId { get; set; }

    public Guid? MasterEmailNotificationId { get; set; }

    public string? Name { get; set; }

    public string? SubjectQuery { get; set; }

    public string? BodyTitleQuery { get; set; }

    public string? Pre { get; set; }

    public string? Query { get; set; }

    public string? Post { get; set; }

    public string? TotalQuery { get; set; }

    public int? ScheduleFrequency { get; set; }

    public DateTime? ScheduleDateTime { get; set; }

    public bool? EnableFlag { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
