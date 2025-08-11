using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class TransactionSubCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? TransectionCategoryId { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedDate { get; set; }

    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    public virtual TransactionCategory? TransectionCategory { get; set; }
}
