using System;
using System.Collections.Generic;

namespace AmazonAPI.Models;

public partial class BrainTreeStatement
{
    public int BrainTreeId { get; set; }

    public DateTime? DisbursementDate { get; set; }

    public double? GrossSalesUsd { get; set; }

    public double? DiscountUsd { get; set; }

    public double? PerTransactionFeesUsd { get; set; }

    public double? OtherFeesUsd { get; set; }

    public double? ChargebacksLostWonUsd { get; set; }

    public double? RefundsUsd { get; set; }

    public double? TotalFeeCreditsUsd { get; set; }

    public double? HoldsReleasesUsd { get; set; }

    public double? OfRefunds { get; set; }

    public double? OfFeeCredits { get; set; }

    public double? DiscountCreditsUsd { get; set; }

    public double? PerTransactionFeeCreditsUsd { get; set; }

    public double? FeeCreditsUsd { get; set; }

    public double? ChargebackWonAmtUsd { get; set; }

    public double? OfChargebacksWon { get; set; }

    public double? ChargebackIssuedAmtUsd { get; set; }

    public double? OfChargebacksIssued { get; set; }

    public double? ChargebackFeesUsd { get; set; }
}
