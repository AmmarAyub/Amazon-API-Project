using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class StripePayment
{
    public int PaymentId { get; set; }

    public string? Id { get; set; }

    public string? Description { get; set; }

    public string? SellerMessage { get; set; }

    public DateTime? Created { get; set; }

    public decimal? Amount { get; set; }

    public decimal? AmountRefunded { get; set; }

    public string? Currency { get; set; }

    public decimal? ConvertedAmount { get; set; }

    public decimal? ConvertedAmountRefunded { get; set; }

    public decimal? Fee { get; set; }

    public decimal? Tax { get; set; }

    public string? ConvertedCurrency { get; set; }

    public string? Status { get; set; }

    public string? StatementDescriptor { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerDescription { get; set; }

    public string? CustomerEmail { get; set; }

    public bool? Captured { get; set; }

    public string? CardId { get; set; }

    public string? InvoiceId { get; set; }

    public string? Transfer { get; set; }

    public string? MerchantReference { get; set; }

    public string? Email { get; set; }

    public string? Name { get; set; }

    public string? StripeAccountName { get; set; }

    public bool AmountFixed { get; set; }
}
