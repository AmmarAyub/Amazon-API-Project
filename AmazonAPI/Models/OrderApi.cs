using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class OrderApi
{
    public int OrderId { get; set; }

    public int? CompanyId { get; set; }

    public double? BaseHandlingCost { get; set; }

    public double? BaseShippingCost { get; set; }

    public double? BaseWrappingCost { get; set; }

    public string? BillingAddressCity { get; set; }

    public string? BillingAddressCompany { get; set; }

    public string? BillingAddressCountry { get; set; }

    public string? BillingAddressCountryIso2 { get; set; }

    public string? BillingAddressEmail { get; set; }

    public string? BillingAddressFirstName { get; set; }

    public string? BillingAddressFormFields { get; set; }

    public string? BillingAddressLastName { get; set; }

    public double? BillingAddressPhone { get; set; }

    public string? BillingAddressState { get; set; }

    public string? BillingAddressStreet1 { get; set; }

    public string? BillingAddressStreet2 { get; set; }

    public int? BillingAddressZip { get; set; }

    public string? CartId { get; set; }

    public int? ChannelId { get; set; }

    public double? CouponDiscount { get; set; }

    public string? CouponsResource { get; set; }

    public string? CouponsUrl { get; set; }

    public string? CreditCardType { get; set; }

    public string? CurrencyCode { get; set; }

    public double? CurrencyExchangeRate { get; set; }

    public int? CurrencyId { get; set; }

    public string? CustomStatus { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerLocale { get; set; }

    public string? CustomerMessage { get; set; }

    public string? DateCreated { get; set; }

    public string? DateModified { get; set; }

    public string? DateShipped { get; set; }

    public string? DefaultCurrencyCode { get; set; }

    public int? DefaultCurrencyId { get; set; }

    public double? DiscountAmount { get; set; }

    public int? EbayOrderId { get; set; }

    public string? ExternalId { get; set; }

    public string? ExternalMerchantId { get; set; }

    public string? ExternalSource { get; set; }

    public string? GeoipCountry { get; set; }

    public string? GeoipCountryIso2 { get; set; }

    public double? GiftCertificateAmount { get; set; }

    public double? HandlingCostExTax { get; set; }

    public double? HandlingCostIncTax { get; set; }

    public double? HandlingCostTax { get; set; }

    public int? HandlingCostTaxClassId { get; set; }

    public int? Id { get; set; }

    public string? IpAddress { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsEmailOptIn { get; set; }

    public int? ItemsShipped { get; set; }

    public int? ItemsTotal { get; set; }

    public bool? OrderIsDigital { get; set; }

    public string? OrderSource { get; set; }

    public string? PaymentMethod { get; set; }

    public string? PaymentProviderId { get; set; }

    public string? PaymentStatus { get; set; }

    public string? ProductsResource { get; set; }

    public string? ProductsUrl { get; set; }

    public double? RefundedAmount { get; set; }

    public int? ShippingAddressCount { get; set; }

    public string? ShippingAddressesResource { get; set; }

    public string? ShippingAddressesUrl { get; set; }

    public double? ShippingCostExTax { get; set; }

    public double? ShippingCostIncTax { get; set; }

    public double? ShippingCostTax { get; set; }

    public int? ShippingCostTaxClassId { get; set; }

    public string? StaffNotes { get; set; }

    public string? Status { get; set; }

    public int? StatusId { get; set; }

    public double? StoreCreditAmount { get; set; }

    public string? StoreDefaultCurrencyCode { get; set; }

    public double? StoreDefaultToTransactionalExchangeRate { get; set; }

    public double? SubtotalExTax { get; set; }

    public double? SubtotalIncTax { get; set; }

    public double? SubtotalTax { get; set; }

    public string? TaxProviderId { get; set; }

    public double? TotalExTax { get; set; }

    public double? TotalIncTax { get; set; }

    public double? TotalTax { get; set; }

    public double? WrappingCostExTax { get; set; }

    public double? WrappingCostIncTax { get; set; }

    public double? WrappingCostTax { get; set; }

    public int? WrappingCostTaxClassId { get; set; }
}
