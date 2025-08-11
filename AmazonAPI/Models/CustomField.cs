using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class CustomField
{
    public int CustomFieldId { get; set; }

    public int? FormId { get; set; }

    public string? CustomFieldName { get; set; }

    public int? CustomFieldTypeId { get; set; }

    public string? DataType { get; set; }

    public int? CustomerFieldSequence { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual AspNetUser? CreatedByNavigation { get; set; }
}
