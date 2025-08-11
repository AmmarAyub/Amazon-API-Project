using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Instruction
{
    public int InstructionId { get; set; }

    public string? InsHeading { get; set; }

    public string? InsDetails { get; set; }

    public string? DocPath { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual ICollection<TaskResponsibility> TaskResponsibilities { get; set; } = new List<TaskResponsibility>();
}
