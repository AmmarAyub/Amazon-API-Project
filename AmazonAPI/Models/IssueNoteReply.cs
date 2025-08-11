using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class IssueNoteReply
{
    public int NotesReplyId { get; set; }

    public int? NoteId { get; set; }

    public string? UserId { get; set; }

    public string? NoteReplyText { get; set; }

    public DateTime? CreateDate { get; set; }

    public bool? IsRead { get; set; }

    public virtual IssueNote? Note { get; set; }

    public virtual AspNetUser? User { get; set; }
}
