using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class TaskResponsibility
{
    public int TaskId { get; set; }

    public string? TaskName { get; set; }

    public bool? DailySchedule { get; set; }

    public bool? WeeklySchedule { get; set; }

    public bool? MonthlySchedule { get; set; }

    public int? DailyRecursion { get; set; }

    public int? WeeklyRecursion { get; set; }

    public int? InstructionId { get; set; }

    public string? Notes { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual Instruction? Instruction { get; set; }

    public virtual ICollection<ResponsibilityUser> ResponsibilityUsers { get; set; } = new List<ResponsibilityUser>();

    public virtual ICollection<Scheduler> Schedulers { get; set; } = new List<Scheduler>();
}
