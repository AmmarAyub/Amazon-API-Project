using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Attachment
{
    public int AttachmentId { get; set; }

    public int FormId { get; set; }

    public int DocId { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string FilePath { get; set; } = null!;

    public virtual Form Form { get; set; } = null!;
}
