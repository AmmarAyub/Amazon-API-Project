using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class ViewGetTapeGoogleSheet
{
    public string? InvDate { get; set; }

    public string? ExternalInvoiceNo { get; set; }

    public string? ItemCode { get; set; }

    public int? InvoiceId { get; set; }

    public decimal InvQty { get; set; }

    public decimal SellingPrice { get; set; }

    public decimal? InvoiceTotal { get; set; }

    public string PaymentTerm { get; set; } = null!;

    public string Logistics { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string? TrackingInfo { get; set; }

    public string? PurchaseDate { get; set; }

    public int? PurchaseOrdersId { get; set; }

    public decimal PurchasePrice { get; set; }

    public decimal Poqty { get; set; }

    public string? Porefrence { get; set; }

    public int? InvEmpId { get; set; }

    public int? InvCoId { get; set; }

    public int? PoempId { get; set; }

    public int? PocoId { get; set; }

    public decimal? Profit { get; set; }

    public string? CompanyName { get; set; }

    public decimal? PurchaseOrdersTotal { get; set; }

    public decimal? GrossProfit { get; set; }
}
