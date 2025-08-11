using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AmazonAllPnL
{
    public string? OrderSource { get; set; }

    public string? OrderId { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime? LatestShipDate { get; set; }

    public string? Sku { get; set; }

    public string? Title { get; set; }

    public int? Quantity { get; set; }

    public decimal? SellingPrice { get; set; }

    public decimal? ItemTaxAmount { get; set; }

    public decimal? SellingTotal { get; set; }

    public string? ShippingProgram { get; set; }

    public string? ShipMethod { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? SellingStatus { get; set; }

    public string? VendorName { get; set; }

    public int PurchaseOrdersId { get; set; }

    public decimal? PurchaseTotal { get; set; }

    public double? TaxPaidOnPurchase { get; set; }

    public decimal? Freight { get; set; }

    public double? PurchaseTotalWithTax { get; set; }

    public double? MarketplaceFee { get; set; }

    public double? EstimatedProfit { get; set; }

    public string? PurchaseOrderStatus { get; set; }

    public string? VendorShipVia { get; set; }

    public string? TrackingId { get; set; }

    public DateTime? VendorShipDate { get; set; }

    public string? TrackingStatus { get; set; }
}
