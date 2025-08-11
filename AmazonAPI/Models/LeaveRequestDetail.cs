using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class LeaveRequestDetail
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int? CausualBalance { get; set; }

    public int? SickBalance { get; set; }

    public int? WorkFromHome { get; set; }

    public int? AnnualBalance { get; set; }

    public double? HalfDayLeaves { get; set; }

    public double? QuarterLeaves { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public double? LeaveDays { get; set; }

    public int LeaveTypeId { get; set; }

    public string? LeaveDetails { get; set; }

    public int? LeaveStatus { get; set; }

    public DateOnly? ApprovalDate { get; set; }

    public int ApprovedBy { get; set; }

    public DateOnly? Hstrydate { get; set; }

    public virtual Employee Emp { get; set; } = null!;

    public virtual List? LeaveStatusNavigation { get; set; }

    public virtual LeaveTypeList LeaveType { get; set; } = null!;
}
