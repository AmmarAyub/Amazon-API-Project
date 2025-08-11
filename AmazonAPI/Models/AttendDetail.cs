using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AttendDetail
{
    public int AttId { get; set; }

    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public TimeOnly? CheckInTime { get; set; }

    public TimeOnly? CheckOutTime { get; set; }

    public int? HId { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual LeaveTypeList? HIdNavigation { get; set; }

    public virtual AttendanceRecord IdNavigation { get; set; } = null!;
}
