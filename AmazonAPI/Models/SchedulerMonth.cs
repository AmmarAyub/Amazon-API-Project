using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class SchedulerMonth
{
    public int SchedulerMonthsId { get; set; }

    public string? SchedulerMonths { get; set; }

    public virtual ICollection<Scheduler> Schedulers { get; set; } = new List<Scheduler>();
}
