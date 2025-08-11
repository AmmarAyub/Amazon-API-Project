using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class SchedulerWeek
{
    public int SchedulerWeeksId { get; set; }

    public string? SchedulerWeeks { get; set; }

    public virtual ICollection<Scheduler> Schedulers { get; set; } = new List<Scheduler>();
}
