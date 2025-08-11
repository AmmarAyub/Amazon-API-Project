using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewPoInvTracking
{
    public string? FullName { get; set; }

    public string? ItemCode { get; set; }

    public string? CustomerName { get; set; }

    public int ProductId { get; set; }

    public string? InvDate { get; set; }

    public int? InvoiceId { get; set; }

    public decimal SellingPrice { get; set; }

    public decimal InvQty { get; set; }

    public string? PurchaseDate { get; set; }

    public int? PurchaseOrdersId { get; set; }

    public decimal PurchasePrice { get; set; }

    public decimal Poqty { get; set; }

    public int? InvEmpId { get; set; }

    public int? InvCoId { get; set; }

    public int? PoempId { get; set; }

    public int? PocoId { get; set; }

    public decimal? Profit { get; set; }

    public string? CompanyName { get; set; }

    public string Name { get; set; } = null!;
}
