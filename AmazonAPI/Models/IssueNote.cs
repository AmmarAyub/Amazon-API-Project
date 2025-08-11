using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class IssueNote
{
    public int NoteId { get; set; }

    public int? IssueId { get; set; }

    public string? NoteDescription { get; set; }

    public string? HstryUserId { get; set; }

    public DateTime HstryDateTime { get; set; }

    public string? FilePath { get; set; }

    public bool? IsRead { get; set; }

    public virtual AspNetUser? HstryUser { get; set; }

    public virtual Issue? Issue { get; set; }

    public virtual ICollection<IssueNoteReply> IssueNoteReplies { get; set; } = new List<IssueNoteReply>();
}
