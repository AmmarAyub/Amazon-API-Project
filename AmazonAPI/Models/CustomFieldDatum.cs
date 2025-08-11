using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class CustomFieldDatum
{
    public int CustomFieldDataId { get; set; }

    public int CustomFieldId { get; set; }

    public string? CustomerFieldDataValue { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual AspNetUser? CreatedByNavigation { get; set; }
}
