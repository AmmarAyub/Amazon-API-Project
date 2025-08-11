using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Schedule
{
    public Guid ScheduleId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? TaskName { get; set; }

    public string? TableName { get; set; }

    public string? InsertStatement { get; set; }

    public int? AssignedTo { get; set; }

    public int? DaysReq { get; set; }

    public int? ScheduleFrequencyDays { get; set; }

    public DateTime? LastRunDate { get; set; }

    public DateTime? NextRunDate { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual Employee? AssignedToNavigation { get; set; }
}
