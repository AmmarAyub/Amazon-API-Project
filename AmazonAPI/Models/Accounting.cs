using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Accounting
{
    public string? DateTime { get; set; }

    public long? SettlementId { get; set; }

    public string? Type { get; set; }

    public string? OrderId { get; set; }

    public string? Sku { get; set; }

    public string? Description { get; set; }

    public byte? Quantity { get; set; }

    public string? Marketplace { get; set; }

    public string? AccountType { get; set; }

    public string? Fulfillment { get; set; }

    public string? OrderCity { get; set; }

    public string? OrderState { get; set; }

    public string? OrderPostal { get; set; }

    public string? TaxCollectionModel { get; set; }

    public double? ProductSales { get; set; }

    public double? ProductSalesTax { get; set; }

    public double? ShippingCredits { get; set; }

    public double? ShippingCreditsTax { get; set; }

    public double? MarketplaceWithheldTax { get; set; }

    public double? SellingFees { get; set; }

    public double? FbaFees { get; set; }

    public double? OtherTransactionFees { get; set; }

    public double? Other { get; set; }

    public double? Total { get; set; }
}
