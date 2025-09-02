namespace AmazonAPI.Models
{
    public class AmazonNotShippedModel
    {
        public string? AmazonOrderID { get; set; }
        public string? SellerSKU { get; set; }
        public string? AmazonOrderStatus { get; set; }
        public string? Code { get; set; }
        public DateTime ResponseDateTime { get; set; }
        //public string? OrderStatus { get; set; }
        //public int OrderCounts { get; set; }
        //public string? OrderTotal { get; set; }
        public string? Stock { get; set; }
        public decimal Cost { get; set; }
        public decimal? Sold { get; set; }
        public decimal? GP { get; set; }
        //public int? DaysTook { get; set; }
        public int? DaysInProcess { get; set; }
    }

    public class AmazonOrdersStats
    {
        public string OrderStatus { get; set; }
        public int OrderCounts { get; set; }
        public string OrderTotal { get; set; }
    }

    public class AmazonShippedModel
    {
        public string AmazonOrderID { get; set; }
        public string PONumber { get; set; }
        public DateTime ShipDatetime { get; set; }
        public DateTime PODatetime { get; set; }
        public decimal POTotal { get; set; }
        public string ShipMethodDescription { get; set; }
        public string TrackingNumber { get; set; }
        public string SynnexCode { get; set; }
        public string AmazonOrderStatus { get; set; }
        public int DaysTook { get; set; }
    }
    public class AmazonFakeTrackingModel
    {
        public int ID { get; set; }
        public string AmazonOrderID { get; set; }
        public string FakeTrackingID { get; set; }
        public string RealTracking { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
