using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class AmazonOrderReport
{
    public string OrderId { get; set; } = null!;

    public string? OrderItemId { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime? PaymentsDate { get; set; }

    public string? BuyerEmail { get; set; }

    public string? BuyerName { get; set; }

    public string? Cpf { get; set; }

    public string? BuyerPhoneNumber { get; set; }

    public string? Sku { get; set; }

    public int? NumberOfItems { get; set; }

    public string? ProductName { get; set; }

    public int? QuantityPurchased { get; set; }

    public string? Currency { get; set; }

    public double? ItemPrice { get; set; }

    public double? ItemTax { get; set; }

    public double? ShippingPrice { get; set; }

    public double? ShippingTax { get; set; }

    public string? ShipServiceLevel { get; set; }

    public string? RecipientName { get; set; }

    public string? ShipAddress1 { get; set; }

    public string? ShipAddress2 { get; set; }

    public string? ShipAddress3 { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipState { get; set; }

    public string? ShipPostalCode { get; set; }

    public string? ShipCountry { get; set; }

    public string? ShipPhoneNumber { get; set; }

    public string? DeliveryStartDate { get; set; }

    public string? DeliveryEndDate { get; set; }

    public string? DeliveryTimeZone { get; set; }

    public string? DeliveryInstructions { get; set; }

    public string? PaymentMethod { get; set; }

    public double? CodCollectibleAmount { get; set; }

    public double? AlreadyPaid { get; set; }

    public double? PaymentMethodFee { get; set; }

    public string? EarliestShipDate { get; set; }

    public string? LatestShipDate { get; set; }

    public string? EarliestDeliveryDate { get; set; }

    public string? LatestDeliveryDate { get; set; }

    public string? IsBusinessOrder { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? PriceDesignation { get; set; }

    public string? BuyerCompanyName { get; set; }

    public string? TaxCollectionModel { get; set; }

    public string? TaxCollectionResponsibleParty { get; set; }

    public string? SignatureConfirmationRecommended { get; set; }
}
