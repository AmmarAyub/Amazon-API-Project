using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Budget
{
    public int BudgetId { get; set; }

    public int? CompanyId { get; set; }

    public int? CategoryId { get; set; }

    public decimal? CategoryAmount { get; set; }

    public int? SubCategoryId { get; set; }

    public decimal? SubCategoryAmount { get; set; }

    public string? Details { get; set; }

    public int? ContactId { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual TransactionCategory? Category { get; set; }

    public virtual Company? Company { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual TransactionSubCategory? SubCategory { get; set; }
}
