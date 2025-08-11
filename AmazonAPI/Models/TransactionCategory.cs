using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class TransactionCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Position { get; set; }

    public string? AddedBy { get; set; }

    public DateTime? AddedDate { get; set; }

    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    public virtual ICollection<TransactionSubCategory> TransactionSubCategories { get; set; } = new List<TransactionSubCategory>();
}
