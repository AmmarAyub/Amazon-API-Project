using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class OrderItem
{
    public int OrderItemIdlocal { get; set; }

    public string? TaxCollectionModel { get; set; }

    public string? TaxCollectionResponsibleParty { get; set; }

    public string? ProductInfoNumberOfItems { get; set; }

    public string? ItemTaxCurrencyCode { get; set; }

    public string? ItemTaxAmount { get; set; }

    public int? QuantityShipped { get; set; }

    public string? BuyerRequestedCancelIsBuyerRequestedCancel { get; set; }

    public string? BuyerRequestedCancelBuyerCancelReason { get; set; }

    public string? ItemPriceCurrencyCode { get; set; }

    public string? ItemPriceAmount { get; set; }

    public string? Asin { get; set; }

    public string? SellerSku { get; set; }

    public string? Title { get; set; }

    public string? IsGift { get; set; }

    public string? PriceDesignation { get; set; }

    public string? ConditionSubtypeId { get; set; }

    public bool? IsTransparency { get; set; }

    public int? QuantityOrdered { get; set; }

    public string? PromotionDiscountTaxCurrencyCode { get; set; }

    public string? PromotionDiscountTaxAmount { get; set; }

    public string? ConditionId { get; set; }

    public string? PromotionDiscountCurrencyCode { get; set; }

    public string? PromotionDiscountAmount { get; set; }

    public string? OrderItemId { get; set; }

    public string? AmazonOrderId { get; set; }
}
