using System.Globalization;
using System.Text.Json.Serialization;

namespace AmazonAPI.Models.ModelClasses
{
    public class AmazonDashboardViewModel
    {
        /// <summary>
        /// List of all orders matching the filter criteria
        /// </summary>
        public List<AmazonAllPnL> AllOrders { get; set; } = new List<AmazonAllPnL>();

        /// <summary>
        /// List of current month orders (subset of AllOrders)
        /// </summary>
        public List<AmazonAllPnL> CurrentMonthOrders { get; set; } = new List<AmazonAllPnL>();

        /// <summary>
        /// Calculated metrics for the dashboard
        /// </summary>
        public DashboardMetrics Metrics { get; set; } = new DashboardMetrics();

        /// <summary>
        /// Selected time period filter ("current", "previous", "yeartodate")
        /// </summary>
        public string SelectedPeriod { get; set; } = "current";
    }
    public class DashboardMetrics
    {
        /// <summary>
        /// Total number of orders
        /// </summary>
        public int OrderCount { get; set; } = 0;

        /// <summary>
        /// Sum of estimated profit across all orders
        /// </summary>
        public decimal TotalProfit { get; set; } = 0;

        /// <summary>
        /// Total purchase amount including tax
        /// </summary>
        public decimal TotalPurchases { get; set; } = 0;

        /// <summary>
        /// Total freight costs
        /// </summary>
        public decimal TotalFreight { get; set; } = 0;

        /// <summary>
        /// Total sales amount
        /// </summary>
        public decimal TotalSales { get; set; } = 0;

        /// <summary>
        /// Total marketplace fees
        /// </summary>
        public decimal TotalMarketplaceFee { get; set; } = 0;

        /// <summary>
        /// Culture information for formatting values
        /// </summary>
        //public CultureInfo CultureInfo { get; set; } = CultureInfo.CurrentCulture;
        [JsonIgnore]
        public CultureInfo CultureInfo { get; set; } = CultureInfo.CurrentCulture;

        [JsonPropertyName("culture")]
        public string Culture => CultureInfo?.Name ?? string.Empty;

        /// <summary>
        /// Display-friendly period description
        /// </summary>
        public string PeriodDisplay { get; set; } = string.Empty;
    }
}
