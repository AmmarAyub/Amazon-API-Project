using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Bigcomerce1
{
    public int OrderId { get; set; }

    public byte CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string CustomerEmail { get; set; } = null!;

    public string? CustomerPhone { get; set; }

    public DateOnly OrderDate { get; set; }

    public string OrderStatus { get; set; } = null!;

    public double SubtotalIncTax { get; set; }

    public double SubtotalExTax { get; set; }

    public double TaxTotal { get; set; }

    public double ShippingCostIncTax { get; set; }

    public double ShippingCostExTax { get; set; }

    public string ShipMethod { get; set; } = null!;

    public double HandlingCostIncTax { get; set; }

    public double HandlingCostExTax { get; set; }

    public double StoreCreditRedeemed { get; set; }

    public double GiftCertificateAmountRedeemed { get; set; }

    public string? GiftCertificateCode { get; set; }

    public string? GiftCertificateExpirationDate { get; set; }

    public string? CouponDetails { get; set; }

    public double OrderTotalIncTax { get; set; }

    public double OrderTotalExTax { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public byte TotalQuantity { get; set; }

    public byte TotalShipped { get; set; }

    public DateOnly? DateShipped { get; set; }

    public string OrderCurrencyCode { get; set; } = null!;

    public double ExchangeRate { get; set; }

    public string? OrderNotes { get; set; }

    public string? CustomerMessage { get; set; }

    public string BillingFirstName { get; set; } = null!;

    public string BillingLastName { get; set; } = null!;

    public string? BillingCompany { get; set; }

    public string BillingStreet1 { get; set; } = null!;

    public string? BillingStreet2 { get; set; }

    public string BillingSuburb { get; set; } = null!;

    public string? BillingState { get; set; }

    public string BillingZip { get; set; } = null!;

    public string BillingCountry { get; set; } = null!;

    public string? BillingPhone { get; set; }

    public string BillingEmail { get; set; } = null!;

    public string ShippingFirstName { get; set; } = null!;

    public string ShippingLastName { get; set; } = null!;

    public string? ShippingCompany { get; set; }

    public string ShippingStreet1 { get; set; } = null!;

    public string? ShippingStreet2 { get; set; }

    public string ShippingSuburb { get; set; } = null!;

    public string? ShippingState { get; set; }

    public string ShippingZip { get; set; } = null!;

    public string ShippingCountry { get; set; } = null!;

    public string? ShippingPhone { get; set; }

    public string? ShippingEmail { get; set; }

    public string ProductDetails { get; set; } = null!;

    public double RefundAmount { get; set; }
}
