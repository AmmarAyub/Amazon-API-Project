namespace AmazonAPI.Models
{
    using System;
    using System.Collections.Generic;
    public class InvoiceModel
    {
        public int InvoiceID { get; set; }
        public string ExternalInvoiceNO { get; set; }
        public Nullable<int> ContactID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string Dates { get; set; }
        public DateTime Date { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<int> ShipVia { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public Nullable<int> PaymentTerm { get; set; }
        public int ShipToContactID { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<int> InvoiceStage { get; set; }
        public Nullable<decimal> InvoiceTotal { get; set; }
        public Nullable<decimal> InvoiceSubTotal { get; set; }
        public string Sale_InvoiceIdID { get; set; }
        public Nullable<int> TaxID { get; set; }
        public Nullable<bool> IsPaid { get; set; }
        //public int Status { get; set; }
        public string Status { get; set; }
        public string PORefrence { get; set; }
        public string Ref { get; set; }
        public string reference { get; set; }
        public string Comment { get; set; }
        public string TermAndCondition { get; set; }
        public string TrackingInfo { get; set; }
        public string HstryUserID { get; set; }
        public Nullable<System.DateTime> HstryDateTime { get; set; }
        public decimal AcountBalance { get; set; }
        public int InvoicesCount { get; set; }
        public int TotalInv { get; set; }
        public string Total { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string TypeofTran { get; set; }
        public virtual Company Company { get; set; }
        public virtual ContactCompany ContactCompany { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual List List { get; set; }
        public virtual List List1 { get; set; }
        public virtual Shipper Shipper { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt_Invoices> Receipt_Invoices { get; set; }


        //InvoiceDetail
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string ItemCode { get; set; }
        public string ProductName { get; set; }
        public int PurchaseOrderID { get; set; }
        public int PurchaseOrderDetailID { get; set; }
        public string Note { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public bool Tax { get; set; }
        public Product Products { get; set; }
        public decimal PurchasePrice { get; set; }
        public bool IsTrackable { get; set; }
    }

    public class InvModel
    {
        public DateTime Date { get; set; }
        public string CompanyName { get; set; }
        public string Total { get; set; }
        public string Status { get; set; }
    }
    }
