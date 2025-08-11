using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public string? AmazonOrderId { get; set; }

    public string? EarliestShipDate { get; set; }

    public string? SalesChannel { get; set; }

    public string? AutomatedShippingSettingsHasAutomatedShippingSettings { get; set; }

    public string? OrderStatus { get; set; }

    public int? NumberOfItemsShipped { get; set; }

    public string? OrderType { get; set; }

    public string? IsPremiumOrder { get; set; }

    public string? IsPrime { get; set; }

    public string? FulfillmentChannel { get; set; }

    public bool? NumberOfItemsUnshipped { get; set; }

    public string? HasRegulatedItems { get; set; }

    public string? IsReplacementOrder { get; set; }

    public string? IsSoldByAb { get; set; }

    public string? LatestShipDate { get; set; }

    public string? ShipServiceLevel { get; set; }

    public string? IsIspu { get; set; }

    public string? MarketplaceId { get; set; }

    public string? PurchaseDate { get; set; }

    public string? IsAccessPointOrder { get; set; }

    public string? IsBusinessOrder { get; set; }

    public string? PaymentMethodDetails { get; set; }

    public string? IsGlobalExpressEnabled { get; set; }

    public string? LastUpdateDate { get; set; }

    public string? ShipmentServiceLevelCategory { get; set; }

    public string? BuyerInfoBuyerEmail { get; set; }

    public string? EarliestDeliveryDate { get; set; }

    public string? DefaultShipFromLocationAddressAddressLine2 { get; set; }

    public string? DefaultShipFromLocationAddressStateOrRegion { get; set; }

    public string? DefaultShipFromLocationAddressAddressLine1 { get; set; }

    public string? DefaultShipFromLocationAddressPostalCode { get; set; }

    public string? DefaultShipFromLocationAddressCity { get; set; }

    public string? DefaultShipFromLocationAddressCountryCode { get; set; }

    public string? DefaultShipFromLocationAddressName { get; set; }

    public string? LatestDeliveryDate { get; set; }

    public string? ShippingAddressStateOrRegion { get; set; }

    public string? ShippingAddressPostalCode { get; set; }

    public string? ShippingAddressCity { get; set; }

    public string? ShippingAddressCountryCode { get; set; }

    public string? PaymentMethod { get; set; }

    public string? OrderTotalCurrencyCode { get; set; }

    public decimal? OrderTotalAmount { get; set; }

    public bool? Imported { get; set; }
 
}
