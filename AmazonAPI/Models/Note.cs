using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Note
{
    public int NoteId { get; set; }

    public int FormId { get; set; }

    public int TransactionId { get; set; }

    public string? NoteDescription { get; set; }

    public string HstryUserId { get; set; } = null!;

    public DateTime HstryDateTime { get; set; }

    public string? FilePath { get; set; }

    public virtual Form Form { get; set; } = null!;
}
