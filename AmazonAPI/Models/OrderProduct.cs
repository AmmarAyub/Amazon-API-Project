using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class OrderProduct
{
    public int ItemId { get; set; }

    public double? BaseCostPrice { get; set; }

    public double? BasePrice { get; set; }

    public double? BaseTotal { get; set; }

    public double? BaseWrappingCost { get; set; }

    public string? BinPickingNumber { get; set; }

    public double? CostPriceExTax { get; set; }

    public double? CostPriceIncTax { get; set; }

    public double? CostPriceTax { get; set; }

    public double? Depth { get; set; }

    public string? EbayItemId { get; set; }

    public string? EbayTransactionId { get; set; }

    public string? EventDate { get; set; }

    public string? EventName { get; set; }

    public string? ExternalId { get; set; }

    public double? FixedShippingCost { get; set; }

    public string? FulfillmentSource { get; set; }

    public double? Height { get; set; }

    public int? Id { get; set; }

    public bool? IsBundledProduct { get; set; }

    public bool? IsRefunded { get; set; }

    public string? Name { get; set; }

    public string? NameCustomer { get; set; }

    public string? NameMerchant { get; set; }

    public string? OptionSetId { get; set; }

    public int? OrderAddressId { get; set; }

    public int? OrderId { get; set; }

    public string? ParentOrderProductId { get; set; }

    public double? PriceExTax { get; set; }

    public double? PriceIncTax { get; set; }

    public double? PriceTax { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public int? QuantityRefunded { get; set; }

    public int? QuantityShipped { get; set; }

    public double? RefundAmount { get; set; }

    public int? ReturnId { get; set; }

    public string? Sku { get; set; }

    public double? TotalExTax { get; set; }

    public double? TotalIncTax { get; set; }

    public double? TotalTax { get; set; }

    public string? Type { get; set; }

    public string? Upc { get; set; }

    public int? VariantId { get; set; }

    public double? Weight { get; set; }

    public double? Width { get; set; }

    public double? WrappingCostExTax { get; set; }

    public double? WrappingCostIncTax { get; set; }

    public double? WrappingCostTax { get; set; }

    public string? WrappingMessage { get; set; }

    public string? WrappingName { get; set; }
}
