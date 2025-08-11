using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Form
{
    public int FormId { get; set; }

    public string? FormName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsExpense { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual ICollection<EmailTracking> EmailTrackings { get; set; } = new List<EmailTracking>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<TableColList> TableColLists { get; set; } = new List<TableColList>();

    public virtual ICollection<ToolTip> ToolTips { get; set; } = new List<ToolTip>();
}
