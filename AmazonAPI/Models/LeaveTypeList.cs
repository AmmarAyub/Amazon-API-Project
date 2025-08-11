using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class LeaveTypeList
{
    public int HId { get; set; }

    public string? LeaveType { get; set; }

    public virtual ICollection<AttendDetail> AttendDetails { get; set; } = new List<AttendDetail>();

    public virtual ICollection<LeaveRequestDetail> LeaveRequestDetails { get; set; } = new List<LeaveRequestDetail>();
}
