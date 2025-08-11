namespace AmazonAPI.Models
{
    public class AmazonNotShippedModel
    {
        public string? AmazonOrderID { get; set; }
        public string? SellerSKU { get; set; }
        public string? AmazonOrderStatus { get; set; }
        public string? Code { get; set; }
        public DateTime ResponseDateTime { get; set; }
        public string? OrderStatus { get; set; }
        public int OrderCounts { get; set; }
        public string? OrderTotal { get; set; }
        public string? Stock { get; set; }
        public decimal Cost { get; set; }
        public decimal? Sold { get; set; }
        public decimal? GP { get; set; }
        public int DaysTook { get; set; }
        public int DaysInProcess { get; set; }
    }

    public class AmazonOrdersStats
    {
        public string OrderStatus { get; set; }
        public int OrderCounts { get; set; }
        public string OrderTotal { get; set; }
    }
}
