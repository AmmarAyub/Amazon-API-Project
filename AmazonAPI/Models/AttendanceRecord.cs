using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AttendanceRecord
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public DateTime? AddedDate { get; set; }

    public virtual ICollection<AttendDetail> AttendDetails { get; set; } = new List<AttendDetail>();
}
