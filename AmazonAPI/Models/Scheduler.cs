using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Scheduler
{
    public int SchedulerId { get; set; }

    public int? SchedulerWeekId { get; set; }

    public int? SchedulerMonthId { get; set; }

    public string? SchedulerMonthDays { get; set; }

    public int? TaskId { get; set; }

    public virtual SchedulerMonth? SchedulerMonth { get; set; }

    public virtual SchedulerWeek? SchedulerWeek { get; set; }

    public virtual TaskResponsibility? Task { get; set; }
}
