namespace AmazonAPI.Models
{
    public partial class Receipt_Invoices
    {
        public int ID { get; set; }
        public Nullable<int> ReceiptID { get; set; }
        public Nullable<int> InvoiceID { get; set; }
        public Nullable<double> InvoiceAmmount { get; set; }
        public string HstryUserID { get; set; }
        public Nullable<System.DateTime> HstryDateTime { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}
