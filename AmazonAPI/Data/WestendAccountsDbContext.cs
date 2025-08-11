using System;
using System.Collections.Generic;
using AmazonAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AmazonAPI.Data;

public partial class WestendAccountsDbContext : DbContext
{
    public WestendAccountsDbContext()
    {
    }

    public WestendAccountsDbContext(DbContextOptions<WestendAccountsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountBalance> AccountBalances { get; set; }

    public virtual DbSet<AccountNameTemp> AccountNameTemps { get; set; }

    public virtual DbSet<Accountname> Accountnames { get; set; }

    public virtual DbSet<AccountsUpload> AccountsUploads { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AllCard> AllCards { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }

    public virtual DbSet<AssignedCard> AssignedCards { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<AttendDetail> AttendDetails { get; set; }

    public virtual DbSet<AttendanceRecord> AttendanceRecords { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<Bigcomerce1> Bigcomerce1s { get; set; }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<BillDetail> BillDetails { get; set; }

    public virtual DbSet<BrainTreeStatement> BrainTreeStatements { get; set; }

    public virtual DbSet<Budget> Budgets { get; set; }

    public virtual DbSet<Company> Companys { get; set; }

    public virtual DbSet<CompanyApi> CompanyApis { get; set; }

    public virtual DbSet<CompanyPolicy> CompanyPolicies { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactCompany> ContactCompanies { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CustomField> CustomFields { get; set; }

    public virtual DbSet<CustomFieldDatum> CustomFieldData { get; set; }

    public virtual DbSet<DataAccessType> DataAccessTypes { get; set; }

    public virtual DbSet<DataUpdateRule> DataUpdateRules { get; set; }

    public virtual DbSet<DecAllCard> DecAllCards { get; set; }

    public virtual DbSet<Dir> Dirs { get; set; }

    public virtual DbSet<DynamicReport> DynamicReports { get; set; }

    public virtual DbSet<DynamicReportHistory> DynamicReportHistories { get; set; }

    public virtual DbSet<EmailCclist> EmailCclists { get; set; }

    public virtual DbSet<EmailNotification> EmailNotifications { get; set; }

    public virtual DbSet<EmailNotificationsDetail> EmailNotificationsDetails { get; set; }

    public virtual DbSet<EmailToList> EmailToLists { get; set; }

    public virtual DbSet<EmailTracking> EmailTrackings { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeCompany> EmployeeCompanies { get; set; }

    public virtual DbSet<ExecutionLog> ExecutionLogs { get; set; }

    public virtual DbSet<Expence> Expences { get; set; }

    public virtual DbSet<FeesAndCharge> FeesAndCharges { get; set; }

    public virtual DbSet<FinalTransaction> FinalTransactions { get; set; }

    public virtual DbSet<Form> Forms { get; set; }

    public virtual DbSet<FormSequence> FormSequences { get; set; }

    public virtual DbSet<Gfkproduct> Gfkproducts { get; set; }

    public virtual DbSet<GfkproductView> GfkproductViews { get; set; }

    public virtual DbSet<Instruction> Instructions { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    public virtual DbSet<Issue> Issues { get; set; }

    public virtual DbSet<IssueCategory> IssueCategories { get; set; }

    public virtual DbSet<IssueNote> IssueNotes { get; set; }

    public virtual DbSet<IssueNoteReply> IssueNoteReplies { get; set; }

    public virtual DbSet<IssueSubCategory> IssueSubCategories { get; set; }

    public virtual DbSet<Issuebackup> Issuebackups { get; set; }

    public virtual DbSet<Jan2020> Jan2020s { get; set; }

    public virtual DbSet<LeaveRequestDetail> LeaveRequestDetails { get; set; }

    public virtual DbSet<LeaveTypeList> LeaveTypeLists { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<Newtransaction> Newtransactions { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderApi> OrderApis { get; set; }

    public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<PartnerCertificate> PartnerCertificates { get; set; }

    public virtual DbSet<PartnerContact> PartnerContacts { get; set; }

    public virtual DbSet<PartnerDealRegistration> PartnerDealRegistrations { get; set; }

    public virtual DbSet<PartnerLogin> PartnerLogins { get; set; }

    public virtual DbSet<PartnerOpportunity> PartnerOpportunities { get; set; }

    public virtual DbSet<PartnerOpportunityHistory> PartnerOpportunityHistories { get; set; }

    public virtual DbSet<PartnerOpportunityStatus> PartnerOpportunityStatuses { get; set; }

    public virtual DbSet<PartnerProduct> PartnerProducts { get; set; }

    public virtual DbSet<PartnerTraining> PartnerTrainings { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMade> PaymentMades { get; set; }

    public virtual DbSet<PaymentMadeBill> PaymentMadeBills { get; set; }

    public virtual DbSet<PaymentTerm> PaymentTerms { get; set; }

    public virtual DbSet<Porequest> Porequests { get; set; }

    public virtual DbSet<PorequestDetail> PorequestDetails { get; set; }

    public virtual DbSet<Presubtotal> Presubtotals { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductImage> ProductImages { get; set; }

    public virtual DbSet<ProductManufacturer> ProductManufacturers { get; set; }

    public virtual DbSet<ProductsUpload> ProductsUploads { get; set; }

    public virtual DbSet<ProfitSharing> ProfitSharings { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    public virtual DbSet<PurchaseOrdersDetail> PurchaseOrdersDetails { get; set; }

    public virtual DbSet<Quote> Quotes { get; set; }

    public virtual DbSet<QuoteDetail> QuoteDetails { get; set; }

    public virtual DbSet<RealTimeProductSearchAccount> RealTimeProductSearchAccounts { get; set; }

    public virtual DbSet<Receipt> Receipts { get; set; }

    public virtual DbSet<ReceiptInvoice> ReceiptInvoices { get; set; }

    public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }

    public virtual DbSet<ResponsibilityUser> ResponsibilityUsers { get; set; }

    public virtual DbSet<Rma> Rmas { get; set; }

    public virtual DbSet<RoleRight> RoleRights { get; set; }

    public virtual DbSet<Rule> Rules { get; set; }

    public virtual DbSet<SageInvoice> SageInvoices { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduledProcedure> ScheduledProcedures { get; set; }

    public virtual DbSet<Scheduler> Schedulers { get; set; }

    public virtual DbSet<SchedulerMonth> SchedulerMonths { get; set; }

    public virtual DbSet<SchedulerWeek> SchedulerWeeks { get; set; }

    public virtual DbSet<SessionLog> SessionLogs { get; set; }

    public virtual DbSet<ShipTo> ShipTos { get; set; }

    public virtual DbSet<ShipmentTracking> ShipmentTrackings { get; set; }

    public virtual DbSet<Shipper> Shippers { get; set; }

    public virtual DbSet<StateShippingTax> StateShippingTaxes { get; set; }

    public virtual DbSet<StoreProcedureList> StoreProcedureLists { get; set; }

    public virtual DbSet<StoreProcedureParam> StoreProcedureParams { get; set; }

    public virtual DbSet<StripeFee> StripeFees { get; set; }

    public virtual DbSet<StripePayment> StripePayments { get; set; }

    public virtual DbSet<StripeTransaction> StripeTransactions { get; set; }

    public virtual DbSet<Synnex2024> Synnex2024s { get; set; }

    public virtual DbSet<TableColList> TableColLists { get; set; }

    public virtual DbSet<TaskResponsibility> TaskResponsibilities { get; set; }

    public virtual DbSet<TaxRate> TaxRates { get; set; }

    public virtual DbSet<TempInvoiceSubtotal> TempInvoiceSubtotals { get; set; }

    public virtual DbSet<TempStripeItemized> TempStripeItemizeds { get; set; }

    public virtual DbSet<TempTransaction> TempTransactions { get; set; }

    public virtual DbSet<ToolTip> ToolTips { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionCategory> TransactionCategories { get; set; }

    public virtual DbSet<TransactionSubCategory> TransactionSubCategories { get; set; }

    public virtual DbSet<TransactionsLog> TransactionsLogs { get; set; }

    public virtual DbSet<UserRight> UserRights { get; set; }

    public virtual DbSet<VersionTable> VersionTables { get; set; }

    public virtual DbSet<ViewAccountPayableByCompany> ViewAccountPayableByCompanies { get; set; }

    public virtual DbSet<ViewAccountsReceivableByCompany> ViewAccountsReceivableByCompanies { get; set; }

    public virtual DbSet<ViewAdsi> ViewAdsis { get; set; }

    public virtual DbSet<ViewAllPoDetail> ViewAllPoDetails { get; set; }

    public virtual DbSet<ViewAvailableYear> ViewAvailableYears { get; set; }

    public virtual DbSet<ViewBillPayment> ViewBillPayments { get; set; }

    public virtual DbSet<ViewBillRegister> ViewBillRegisters { get; set; }

    public virtual DbSet<ViewBudget> ViewBudgets { get; set; }

    public virtual DbSet<ViewBudgetbyCompany> ViewBudgetbyCompanies { get; set; }

    public virtual DbSet<ViewCurrentMonthReceipt> ViewCurrentMonthReceipts { get; set; }

    public virtual DbSet<ViewCurrentMonthSale> ViewCurrentMonthSales { get; set; }

    public virtual DbSet<ViewDuplicateInvoice> ViewDuplicateInvoices { get; set; }

    public virtual DbSet<ViewGetOpenPurchaseOrder> ViewGetOpenPurchaseOrders { get; set; }

    public virtual DbSet<ViewGetTapeGoogleSheet> ViewGetTapeGoogleSheets { get; set; }

    public virtual DbSet<ViewIndividualProfitShare> ViewIndividualProfitShares { get; set; }

    public virtual DbSet<ViewInventory> ViewInventories { get; set; }

    public virtual DbSet<ViewInvoiceRegister> ViewInvoiceRegisters { get; set; }

    public virtual DbSet<ViewInvoiceSalesId> ViewInvoiceSalesIds { get; set; }

    public virtual DbSet<ViewInvoiceWeeklyTotal> ViewInvoiceWeeklyTotals { get; set; }

    public virtual DbSet<ViewInvoicesReceipt> ViewInvoicesReceipts { get; set; }

    public virtual DbSet<ViewIssueStatus> ViewIssueStatuses { get; set; }

    public virtual DbSet<ViewIssuesAssignedToStatusCount> ViewIssuesAssignedToStatusCounts { get; set; }

    public virtual DbSet<ViewIssuesDetail> ViewIssuesDetails { get; set; }

    public virtual DbSet<ViewIssuesOpenedBy> ViewIssuesOpenedBies { get; set; }

    public virtual DbSet<ViewNatusFirewallDetail> ViewNatusFirewallDetails { get; set; }

    public virtual DbSet<ViewOpenInvoice> ViewOpenInvoices { get; set; }

    public virtual DbSet<ViewOpenInvoiceSuggestedPo> ViewOpenInvoiceSuggestedPos { get; set; }

    public virtual DbSet<ViewOpenSalesOrder> ViewOpenSalesOrders { get; set; }

    public virtual DbSet<ViewOpenTransaction> ViewOpenTransactions { get; set; }

    public virtual DbSet<ViewPLdetail> ViewPLdetails { get; set; }

    public virtual DbSet<ViewPaymentAndTransactionsMatchOnAmount> ViewPaymentAndTransactionsMatchOnAmounts { get; set; }

    public virtual DbSet<ViewPoInvTracking> ViewPoInvTrackings { get; set; }

    public virtual DbSet<ViewPoandInvoicesNotMatched> ViewPoandInvoicesNotMatcheds { get; set; }

    public virtual DbSet<ViewPoregister> ViewPoregisters { get; set; }

    public virtual DbSet<ViewPortal2DashboardInvoice> ViewPortal2DashboardInvoices { get; set; }

    public virtual DbSet<ViewPototalbyVendor> ViewPototalbyVendors { get; set; }

    public virtual DbSet<ViewPowithNoBill> ViewPowithNoBills { get; set; }

    public virtual DbSet<ViewProfitAndLoss> ViewProfitAndLosses { get; set; }

    public virtual DbSet<ViewProfitCompanyWise> ViewProfitCompanyWises { get; set; }

    public virtual DbSet<ViewPurchaseOrderWeeklyTotal> ViewPurchaseOrderWeeklyTotals { get; set; }

    public virtual DbSet<ViewPurchasesbyCoAndVendor> ViewPurchasesbyCoAndVendors { get; set; }

    public virtual DbSet<ViewQuarterlySale> ViewQuarterlySales { get; set; }

    public virtual DbSet<ViewReceiptDetail> ViewReceiptDetails { get; set; }

    public virtual DbSet<ViewReceiptsBeforeInvoice> ViewReceiptsBeforeInvoices { get; set; }

    public virtual DbSet<ViewRepeatWord> ViewRepeatWords { get; set; }

    public virtual DbSet<ViewSalesOrderRegister> ViewSalesOrderRegisters { get; set; }

    public virtual DbSet<ViewSystemsSqlbackup> ViewSystemsSqlbackups { get; set; }

    public virtual DbSet<ViewUploadToTransaction> ViewUploadToTransactions { get; set; }

    public virtual DbSet<ViewUsersAndRole> ViewUsersAndRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-HPH0FS4\\SQLEXPRESS;Database=WestendAccounts;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AccountBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccountBalance");

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BalanceId).HasColumnName("BalanceID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(128)
                .IsFixedLength();
        });

        modelBuilder.Entity<AccountNameTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccountNameTemp");

            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .HasColumnName("Account_Name");
            entity.Property(e => e.CardDescription).HasMaxLength(50);
            entity.Property(e => e.DefaultUser).HasMaxLength(50);
            entity.Property(e => e.IdaccName)
                .HasMaxLength(50)
                .HasColumnName("IDAccName");
            entity.Property(e => e.Last4).HasMaxLength(50);
            entity.Property(e => e.TypeofAccount).HasMaxLength(50);
        });

        modelBuilder.Entity<Accountname>(entity =>
        {
            entity.HasKey(e => e.IdaccName).HasFillFactor(90);

            entity.ToTable("Accountname");

            entity.HasIndex(e => e.IdaccName, "NonClusteredIndex-20200117-182313").HasFillFactor(90);

            entity.Property(e => e.IdaccName).HasColumnName("IDAccName");
            entity.Property(e => e.AccountName).HasColumnName("Account_Name");
            entity.Property(e => e.OtherNames).HasMaxLength(50);
        });

        modelBuilder.Entity<AccountsUpload>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("AccountsUpload");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.Lable).HasMaxLength(50);
            entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Address");

            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .HasColumnName("Address");
            entity.Property(e => e.Attention).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .HasColumnName("Display_Name");
            entity.Property(e => e.Fax).HasMaxLength(1);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Street2).HasMaxLength(50);
        });

        modelBuilder.Entity<AllCard>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId).HasColumnName("Account_Id");

            entity.HasOne(d => d.Account).WithMany(p => p.AllCards)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK_AllCards_Accountname");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_dbo.AspNetRoles")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_dbo.AspNetUsers")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);

            // Ensure PasswordHash is always used
            entity.Property(e => e.NudePassword)
                .HasMaxLength(255)
                .HasColumnName("NudePassword");

            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasColumnName("PasswordHash");
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_dbo.AspNetUserClaims")
                .HasFillFactor(90);

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                .HasName("PK_dbo.AspNetUserLogins")
                .HasFillFactor(90);

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId })
                .HasName("PK_dbo.AspNetUserRoles")
                .HasFillFactor(90);

            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.RoleId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AssignedCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AssignedCard");

            entity.Property(e => e.AccountName).HasMaxLength(50);
            entity.Property(e => e.Amount).HasMaxLength(50);
            entity.Property(e => e.ChargedTo).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).HasFillFactor(90);

            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.FileName).HasMaxLength(50);
            entity.Property(e => e.FilePath).HasMaxLength(200);
            entity.Property(e => e.FormId).HasColumnName("FormID");

            entity.HasOne(d => d.Form).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attachments_Forms");
        });

        modelBuilder.Entity<AttendDetail>(entity =>
        {
            entity.HasKey(e => e.AttId).HasFillFactor(90);

            entity.ToTable("Attend_Details");

            entity.Property(e => e.AttId).HasColumnName("Att_Id");
            entity.Property(e => e.CheckInTime).HasColumnName("CheckIn_Time");
            entity.Property(e => e.CheckOutTime).HasColumnName("CheckOut_Time");
            entity.Property(e => e.HId).HasColumnName("H_Id");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Updated_Date");

            entity.HasOne(d => d.Employee).WithMany(p => p.AttendDetails)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attend_Details_Employees");

            entity.HasOne(d => d.HIdNavigation).WithMany(p => p.AttendDetails)
                .HasForeignKey(d => d.HId)
                .HasConstraintName("FK_Attend_Details_LeaveType_List");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.AttendDetails)
                .HasForeignKey(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attend_Details_Attendance_Record");
        });

        modelBuilder.Entity<AttendanceRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Attendance_Record");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Added_Date");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AuditLog");

            entity.Property(e => e.AuditAction)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.AuditCommandCreated).IsUnicode(false);
            entity.Property(e => e.AuditCommandDeleted).IsUnicode(false);
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LogId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("LogID");
            entity.Property(e => e.Login).HasMaxLength(150);
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<Bigcomerce1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Bigcomerce1");

            entity.Property(e => e.BillingCompany)
                .HasMaxLength(100)
                .HasColumnName("Billing_Company");
            entity.Property(e => e.BillingCountry)
                .HasMaxLength(50)
                .HasColumnName("Billing_Country");
            entity.Property(e => e.BillingEmail)
                .HasMaxLength(50)
                .HasColumnName("Billing_Email");
            entity.Property(e => e.BillingFirstName)
                .HasMaxLength(50)
                .HasColumnName("Billing_First_Name");
            entity.Property(e => e.BillingLastName)
                .HasMaxLength(50)
                .HasColumnName("Billing_Last_Name");
            entity.Property(e => e.BillingPhone)
                .HasMaxLength(50)
                .HasColumnName("Billing_Phone");
            entity.Property(e => e.BillingState)
                .HasMaxLength(50)
                .HasColumnName("Billing_State");
            entity.Property(e => e.BillingStreet1)
                .HasMaxLength(100)
                .HasColumnName("Billing_Street_1");
            entity.Property(e => e.BillingStreet2)
                .HasMaxLength(50)
                .HasColumnName("Billing_Street_2");
            entity.Property(e => e.BillingSuburb)
                .HasMaxLength(50)
                .HasColumnName("Billing_Suburb");
            entity.Property(e => e.BillingZip)
                .HasMaxLength(50)
                .HasColumnName("Billing_Zip");
            entity.Property(e => e.CouponDetails)
                .HasMaxLength(1)
                .HasColumnName("Coupon_Details");
            entity.Property(e => e.CustomerEmail)
                .HasMaxLength(50)
                .HasColumnName("Customer_Email");
            entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");
            entity.Property(e => e.CustomerMessage)
                .HasMaxLength(150)
                .HasColumnName("Customer_Message");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.CustomerPhone)
                .HasMaxLength(50)
                .HasColumnName("Customer_Phone");
            entity.Property(e => e.DateShipped).HasColumnName("Date_Shipped");
            entity.Property(e => e.ExchangeRate).HasColumnName("Exchange_Rate");
            entity.Property(e => e.GiftCertificateAmountRedeemed).HasColumnName("Gift_Certificate_Amount_Redeemed");
            entity.Property(e => e.GiftCertificateCode)
                .HasMaxLength(1)
                .HasColumnName("Gift_Certificate_Code");
            entity.Property(e => e.GiftCertificateExpirationDate)
                .HasMaxLength(1)
                .HasColumnName("Gift_Certificate_Expiration_Date");
            entity.Property(e => e.HandlingCostExTax).HasColumnName("Handling_Cost_ex_tax");
            entity.Property(e => e.HandlingCostIncTax).HasColumnName("Handling_Cost_inc_tax");
            entity.Property(e => e.OrderCurrencyCode)
                .HasMaxLength(50)
                .HasColumnName("Order_Currency_Code");
            entity.Property(e => e.OrderDate).HasColumnName("Order_Date");
            entity.Property(e => e.OrderId).HasColumnName("Order_ID");
            entity.Property(e => e.OrderNotes)
                .HasMaxLength(100)
                .HasColumnName("Order_Notes");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .HasColumnName("Order_Status");
            entity.Property(e => e.OrderTotalExTax).HasColumnName("Order_Total_ex_tax");
            entity.Property(e => e.OrderTotalIncTax).HasColumnName("Order_Total_inc_tax");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .HasColumnName("Payment_Method");
            entity.Property(e => e.ProductDetails)
                .HasMaxLength(850)
                .HasColumnName("Product_Details");
            entity.Property(e => e.RefundAmount).HasColumnName("Refund_Amount");
            entity.Property(e => e.ShipMethod)
                .HasMaxLength(50)
                .HasColumnName("Ship_Method");
            entity.Property(e => e.ShippingCompany)
                .HasMaxLength(100)
                .HasColumnName("Shipping_Company");
            entity.Property(e => e.ShippingCostExTax).HasColumnName("Shipping_Cost_ex_tax");
            entity.Property(e => e.ShippingCostIncTax).HasColumnName("Shipping_Cost_inc_tax");
            entity.Property(e => e.ShippingCountry)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Country");
            entity.Property(e => e.ShippingEmail)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Email");
            entity.Property(e => e.ShippingFirstName)
                .HasMaxLength(50)
                .HasColumnName("Shipping_First_Name");
            entity.Property(e => e.ShippingLastName)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Last_Name");
            entity.Property(e => e.ShippingPhone)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Phone");
            entity.Property(e => e.ShippingState)
                .HasMaxLength(50)
                .HasColumnName("Shipping_State");
            entity.Property(e => e.ShippingStreet1)
                .HasMaxLength(100)
                .HasColumnName("Shipping_Street_1");
            entity.Property(e => e.ShippingStreet2)
                .HasMaxLength(100)
                .HasColumnName("Shipping_Street_2");
            entity.Property(e => e.ShippingSuburb)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Suburb");
            entity.Property(e => e.ShippingZip)
                .HasMaxLength(50)
                .HasColumnName("Shipping_Zip");
            entity.Property(e => e.StoreCreditRedeemed).HasColumnName("Store_Credit_Redeemed");
            entity.Property(e => e.SubtotalExTax).HasColumnName("Subtotal_ex_tax");
            entity.Property(e => e.SubtotalIncTax).HasColumnName("Subtotal_inc_tax");
            entity.Property(e => e.TaxTotal).HasColumnName("Tax_Total");
            entity.Property(e => e.TotalQuantity).HasColumnName("Total_Quantity");
            entity.Property(e => e.TotalShipped).HasColumnName("Total_Shipped");
        });

        modelBuilder.Entity<Bill>(entity =>
        {
            entity.HasKey(e => e.BillId).HasFillFactor(90);

            entity.Property(e => e.BillId).HasColumnName("BillID");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillSubTotal).HasColumnType("money");
            entity.Property(e => e.BillTotal).HasColumnType("money");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.PaymentOrderId).HasColumnName("PaymentOrderID");
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.ShipToContactId).HasColumnName("ShipToContactID");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TrackingInfo).HasMaxLength(200);
            entity.Property(e => e.VendorInv).HasMaxLength(50);

            entity.HasOne(d => d.BillStageNavigation).WithMany(p => p.BillBillStageNavigations)
                .HasForeignKey(d => d.BillStage)
                .HasConstraintName("FK_Bills_Lists");

            entity.HasOne(d => d.Company).WithMany(p => p.Bills)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Bills_Companys");

            entity.HasOne(d => d.Contact).WithMany(p => p.Bills)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_Bills_ContactCompany");

            entity.HasOne(d => d.Employee).WithMany(p => p.Bills)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Bills_Employees");

            entity.HasOne(d => d.ShipToContact).WithMany(p => p.Bills)
                .HasForeignKey(d => d.ShipToContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bills_Contacts");

            entity.HasOne(d => d.ShipViaNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.ShipVia)
                .HasConstraintName("FK_Bills_Shippers");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.BillStatusNavigations)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Bills_Lists1");
        });

        modelBuilder.Entity<BillDetail>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Table_1")
                .HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BilId).HasColumnName("BilID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PurchaseDetailId).HasColumnName("PurchaseDetailID");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Bil).WithMany(p => p.BillDetails)
                .HasForeignKey(d => d.BilId)
                .HasConstraintName("FK_BillDetails_Bills");

            entity.HasOne(d => d.Product).WithMany(p => p.BillDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BillDetails_Products");

            entity.HasOne(d => d.PurchaseDetail).WithMany(p => p.BillDetails)
                .HasForeignKey(d => d.PurchaseDetailId)
                .HasConstraintName("FK_BillDetails_PurchaseOrdersDetails");
        });

        modelBuilder.Entity<BrainTreeStatement>(entity =>
        {
            entity.HasKey(e => e.BrainTreeId).HasFillFactor(90);

            entity.ToTable("BrainTreeStatement");

            entity.Property(e => e.BrainTreeId).HasColumnName("BrainTreeID");
            entity.Property(e => e.ChargebackFeesUsd).HasColumnName("chargeback_fees_USD");
            entity.Property(e => e.ChargebackIssuedAmtUsd).HasColumnName("chargeback_issued_amt_USD");
            entity.Property(e => e.ChargebackWonAmtUsd).HasColumnName("chargeback_won_amt_USD");
            entity.Property(e => e.ChargebacksLostWonUsd).HasColumnName("chargebacks_lost_won_USD");
            entity.Property(e => e.DisbursementDate)
                .HasColumnType("datetime")
                .HasColumnName("disbursement_date");
            entity.Property(e => e.DiscountCreditsUsd).HasColumnName("discount_credits_USD");
            entity.Property(e => e.DiscountUsd).HasColumnName("discount_USD");
            entity.Property(e => e.FeeCreditsUsd).HasColumnName("fee_credits_USD");
            entity.Property(e => e.GrossSalesUsd).HasColumnName("gross_sales_USD");
            entity.Property(e => e.HoldsReleasesUsd).HasColumnName("holds_releases_USD");
            entity.Property(e => e.OfChargebacksIssued).HasColumnName("of_chargebacks_issued");
            entity.Property(e => e.OfChargebacksWon).HasColumnName("of_chargebacks_won");
            entity.Property(e => e.OfFeeCredits).HasColumnName("of_fee_credits");
            entity.Property(e => e.OfRefunds).HasColumnName("of_refunds");
            entity.Property(e => e.OtherFeesUsd).HasColumnName("other_fees_USD");
            entity.Property(e => e.PerTransactionFeeCreditsUsd).HasColumnName("per_transaction_fee_credits_USD");
            entity.Property(e => e.PerTransactionFeesUsd).HasColumnName("per_transaction_fees_USD");
            entity.Property(e => e.RefundsUsd).HasColumnName("refunds_USD");
            entity.Property(e => e.TotalFeeCreditsUsd).HasColumnName("total_fee_credits_USD");
        });

        modelBuilder.Entity<Budget>(entity =>
        {
            entity.HasKey(e => e.BudgetId).HasFillFactor(90);

            entity.ToTable("Budget");

            entity.Property(e => e.BudgetId).HasColumnName("BudgetID");
            entity.Property(e => e.CategoryAmount).HasColumnType("money");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.SubCategoryAmount).HasColumnType("money");
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

            entity.HasOne(d => d.Category).WithMany(p => p.Budgets)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Budget_Transaction_Category");

            entity.HasOne(d => d.Company).WithMany(p => p.Budgets)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Budget_Companys");

            entity.HasOne(d => d.Contact).WithMany(p => p.Budgets)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_Budget_Contacts");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.Budgets)
                .HasForeignKey(d => d.SubCategoryId)
                .HasConstraintName("FK_Budget_Transaction_SubCategory");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.OtherNames, e.Status, e.IsInvoice, e.AddedDate, e.City, e.State, e.ZipCode, e.Tel, e.Fax, e.Email, e.CompanyApprover, e.CompanyCashier, e.Port, e.UseDefaultCredentials, e.EnableSsl, e.StripeAccountNameId }, "NonClusteredIndex-20200117-182411").HasFillFactor(90);

            entity.Property(e => e.AddedBy).HasColumnName("Added_by");
            entity.Property(e => e.AddedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Added_Date");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CompanyApprover).HasMaxLength(128);
            entity.Property(e => e.CompanyCashier).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Fax).HasMaxLength(20);
            entity.Property(e => e.OtherNames).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.StripeAccountNameId).HasColumnName("StripeAccountNameID");
            entity.Property(e => e.Tel).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.ZipCode).HasMaxLength(50);

            entity.HasOne(d => d.StripeAccountName).WithMany(p => p.Companies)
                .HasForeignKey(d => d.StripeAccountNameId)
                .HasConstraintName("FK_Companys_Accountname");
        });

        modelBuilder.Entity<CompanyApi>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("CompanyAPI");

            entity.Property(e => e.Api).HasColumnName("API");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.Token).HasMaxLength(100);

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyApis)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_CompanyAPI_Companys");
        });

        modelBuilder.Entity<CompanyPolicy>(entity =>
        {
            entity.HasKey(e => e.PolicyId).HasFillFactor(90);

            entity.ToTable("CompanyPolicy");

            entity.Property(e => e.PolicyId).HasColumnName("PolicyID");
            entity.Property(e => e.Category).HasMaxLength(500);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SequenceId).HasColumnName("SequenceID");
            entity.Property(e => e.SubCategory).HasMaxLength(500);

            entity.HasOne(d => d.Company).WithMany(p => p.CompanyPolicies)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_CompanyPolicy_Companys");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.ContactId)
                .HasName("PK_Contact")
                .HasFillFactor(90);

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.ContactCompanyId).HasColumnName("ContactCompanyID");
            entity.Property(e => e.ContactTitle).HasMaxLength(255);
            entity.Property(e => e.ContactType).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Department).HasMaxLength(40);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Email2).HasMaxLength(100);
            entity.Property(e => e.Extension).HasMaxLength(10);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.Iso1099).HasColumnName("ISO1099");
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.Mobile).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.PhotoPath).HasMaxLength(255);
            entity.Property(e => e.PostalCode).HasMaxLength(255);
            entity.Property(e => e.Refrence).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(255);

            entity.HasOne(d => d.ContactCompany).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.ContactCompanyId)
                .HasConstraintName("FK_Contacts_ContactCompany");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contacts_Contacts");

            entity.HasOne(d => d.TaxNavigation).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.Tax)
                .HasConstraintName("FK_Contacts_TaxRates");
        });

        modelBuilder.Entity<ContactCompany>(entity =>
        {
            entity.HasKey(e => e.ContactCompanyId).HasFillFactor(90);

            entity.ToTable("ContactCompany");

            entity.Property(e => e.ContactCompanyId).HasColumnName("ContactCompanyID");
            entity.Property(e => e.AccountOwner).HasMaxLength(128);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.ExternalId).HasColumnName("ExternalID");
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .IsFixedLength()
                .HasColumnName("HstryUserID");
            entity.Property(e => e.Iso1099).HasColumnName("ISO1099");
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.PhotoPath).HasMaxLength(255);
            entity.Property(e => e.PostalCode).HasMaxLength(255);
            entity.Property(e => e.State).HasMaxLength(255);

            entity.HasOne(d => d.AccountOwnerNavigation).WithMany(p => p.ContactCompanies)
                .HasForeignKey(d => d.AccountOwner)
                .HasConstraintName("FK_ContactCompany_AspNetUsers");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasFillFactor(90);

            entity.ToTable("Country");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .HasColumnName("Country_Name");
            entity.Property(e => e.Dial).HasMaxLength(50);
            entity.Property(e => e.Iso31661Alpha2)
                .HasMaxLength(50)
                .HasColumnName("ISO3166_1_Alpha_2");
            entity.Property(e => e.Tld)
                .HasMaxLength(50)
                .HasColumnName("TLD");
        });

        modelBuilder.Entity<CustomField>(entity =>
        {
            entity.HasKey(e => e.CustomFieldId).HasFillFactor(90);

            entity.ToTable("CustomField");

            entity.Property(e => e.CustomFieldId).HasColumnName("CustomFieldID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomFieldTypeId).HasColumnName("CustomFieldTypeID");
            entity.Property(e => e.DataType).HasMaxLength(150);
            entity.Property(e => e.FormId).HasColumnName("FormID");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomFields)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_CustomField_AspNetUsers");
        });

        modelBuilder.Entity<CustomFieldDatum>(entity =>
        {
            entity.HasKey(e => e.CustomFieldDataId).HasFillFactor(90);

            entity.Property(e => e.CustomFieldDataId).HasColumnName("CustomFieldDataID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomFieldId).HasColumnName("CustomFieldID");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomFieldData)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_CustomFieldData_CustomFieldData");
        });

        modelBuilder.Entity<DataAccessType>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("DataAccessType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<DataUpdateRule>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.RuleId)
                .ValueGeneratedOnAdd()
                .HasColumnName("RuleID");
        });

        modelBuilder.Entity<DecAllCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DecAll Card");

            entity.Property(e => e.AccountName).HasMaxLength(50);
            entity.Property(e => e.Amount).HasMaxLength(50);
            entity.Property(e => e.ChargedTo).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<Dir>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DirId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DirID");
            entity.Property(e => e.Directory)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DynamicReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.DynamicCss).HasColumnName("DynamicCSS");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ReportArea).HasMaxLength(500);
            entity.Property(e => e.SubReportArea).HasMaxLength(500);
        });

        modelBuilder.Entity<DynamicReportHistory>(entity =>
        {
            entity.HasKey(e => e.DrjobId).HasFillFactor(90);

            entity.ToTable("DynamicReportHistory");

            entity.Property(e => e.DrjobId).HasColumnName("DRJobID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DynamicReportId).HasColumnName("DynamicReportID");
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.Html).HasColumnName("HTML");
            entity.Property(e => e.Isemail).HasColumnName("isemail");
        });

        modelBuilder.Entity<EmailCclist>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("EmailCCList");

            entity.Property(e => e.EmailCc)
                .HasMaxLength(100)
                .HasColumnName("EmailCC");

            entity.HasOne(d => d.Email).WithMany(p => p.EmailCclists)
                .HasForeignKey(d => d.EmailId)
                .HasConstraintName("FK_EmailCCList_EmailCCList");
        });

        modelBuilder.Entity<EmailNotification>(entity =>
        {
            entity.HasKey(e => e.EmailNotificationId).HasFillFactor(90);

            entity.Property(e => e.EmailNotificationId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("EmailNotificationID");
            entity.Property(e => e.BodyTitleQuery).HasMaxLength(500);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EnableFlag).HasDefaultValue(true);
            entity.Property(e => e.MasterEmailNotificationId).HasColumnName("MasterEmailNotificationID");
            entity.Property(e => e.Post).HasMaxLength(500);
            entity.Property(e => e.Pre).HasMaxLength(500);
            entity.Property(e => e.ScheduleDateTime).HasColumnType("datetime");
            entity.Property(e => e.ScheduleFrequency).HasDefaultValue(0);
            entity.Property(e => e.SubjectQuery).HasMaxLength(500);
            entity.Property(e => e.TotalQuery).HasMaxLength(500);
        });

        modelBuilder.Entity<EmailNotificationsDetail>(entity =>
        {
            entity.HasKey(e => e.EmailNotificationsDetailsId).HasFillFactor(90);

            entity.Property(e => e.EmailNotificationsDetailsId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("EmailNotificationsDetailsID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(150);
            entity.Property(e => e.EmailNotificationId).HasColumnName("EmailNotificationID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Subject).HasMaxLength(500);

            entity.HasOne(d => d.Employee).WithMany(p => p.EmailNotificationsDetails)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_EmailNotificationsDetails_Employees");
        });

        modelBuilder.Entity<EmailToList>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("EmailToList");

            entity.Property(e => e.EmailTo).HasMaxLength(100);

            entity.HasOne(d => d.Email).WithMany(p => p.EmailToLists)
                .HasForeignKey(d => d.EmailId)
                .HasConstraintName("FK_EmailToList_EmailToList");
        });

        modelBuilder.Entity<EmailTracking>(entity =>
        {
            entity.HasKey(e => e.EmailId).HasFillFactor(90);

            entity.ToTable("EmailTracking");

            entity.Property(e => e.EmailId).ValueGeneratedNever();
            entity.Property(e => e.EmailSubject).HasMaxLength(100);

            entity.HasOne(d => d.DocumentTypeNavigation).WithMany(p => p.EmailTrackings)
                .HasForeignKey(d => d.DocumentType)
                .HasConstraintName("FK_EmailTracking_Forms");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasFillFactor(90);

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Address).HasMaxLength(60);
            entity.Property(e => e.Address2).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Extension).HasMaxLength(4);
            entity.Property(e => e.FirstName).HasMaxLength(10);
            entity.Property(e => e.HomePhone).HasMaxLength(24);
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.LastName).HasMaxLength(20);
            entity.Property(e => e.Mobile).HasMaxLength(24);
            entity.Property(e => e.Notes).HasColumnType("ntext");
            entity.Property(e => e.PhotoPath).HasMaxLength(255);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.PrimaryCompanyId).HasColumnName("PrimaryCompanyID");
            entity.Property(e => e.Region).HasMaxLength(15);
            entity.Property(e => e.ReportsToId).HasColumnName("ReportsToID");
            entity.Property(e => e.Title).HasMaxLength(30);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.ReportsTo).WithMany(p => p.InverseReportsTo)
                .HasForeignKey(d => d.ReportsToId)
                .HasConstraintName("FK_Employees_Employees");

            entity.HasOne(d => d.User).WithMany(p => p.Employees)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Employees_AspNetUsers");
        });

        modelBuilder.Entity<EmployeeCompany>(entity =>
        {
            entity.HasKey(e => e.EmployeeCompaniesId).HasFillFactor(90);

            entity.Property(e => e.EmployeeCompaniesId).HasColumnName("EmployeeCompaniesID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(200)
                .HasColumnName("HstryUserID");

            entity.HasOne(d => d.Company).WithMany(p => p.EmployeeCompanies)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeCompanies_Companys");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeCompanies)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeCompanies_Employees");
        });

        modelBuilder.Entity<ExecutionLog>(entity =>
        {
            entity.HasKey(e => e.LogId)
                .HasName("PK__Executio__5E5499A8383A2AB5")
                .HasFillFactor(90);

            entity.ToTable("ExecutionLog");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.ExecutionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExecutionTime).HasColumnType("datetime");
            entity.Property(e => e.ProcedureId).HasColumnName("ProcedureID");
            entity.Property(e => e.ProcedureName).HasMaxLength(128);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<Expence>(entity =>
        {
            entity.HasKey(e => e.ExpenseId).HasFillFactor(90);

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ApprovedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CurrentDollorRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.ExpensedBy).HasMaxLength(128);
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.ManagerApproval).HasMaxLength(128);
            entity.Property(e => e.PaidBy).HasMaxLength(128);
            entity.Property(e => e.PaymentContact).HasMaxLength(128);
            entity.Property(e => e.PkrAmmount).HasColumnType("money");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.ExpenceApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .HasConstraintName("FK_Expences_AspNetUsers2");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ExpenceCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Expences_AspNetUsers4");

            entity.HasOne(d => d.ExpensedByNavigation).WithMany(p => p.ExpenceExpensedByNavigations)
                .HasForeignKey(d => d.ExpensedBy)
                .HasConstraintName("FK_Expences_AspNetUsers1");

            entity.HasOne(d => d.ManagerApprovalNavigation).WithMany(p => p.ExpenceManagerApprovalNavigations)
                .HasForeignKey(d => d.ManagerApproval)
                .HasConstraintName("FK_Expences_AspNetUsers3");

            entity.HasOne(d => d.PaidByNavigation).WithMany(p => p.ExpencePaidByNavigations)
                .HasForeignKey(d => d.PaidBy)
                .HasConstraintName("FK_Expences_AspNetUsers");
        });

        modelBuilder.Entity<FeesAndCharge>(entity =>
        {
            entity.HasKey(e => e.FeeId).HasFillFactor(90);

            entity.Property(e => e.FeeId).HasColumnName("FeeID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.PaymentTermId).HasColumnName("PaymentTermID");

            entity.HasOne(d => d.HstryUser).WithMany(p => p.FeesAndCharges)
                .HasForeignKey(d => d.HstryUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FeesAndCharges_AspNetUsers");
        });

        modelBuilder.Entity<FinalTransaction>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Transactions")
                .HasFillFactor(90);

            entity.ToTable("Final_Transactions");

            entity.HasIndex(e => new { e.Id, e.AccountId, e.Date }, "NonClusteredIndex-20200117-182454").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId).HasColumnName("Account_Id");
            entity.Property(e => e.AccountType).HasColumnName("Account_Type");
            entity.Property(e => e.AddedBy).HasColumnName("Added_by");
            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("Added_Date");
            entity.Property(e => e.ContactCompanyId).HasColumnName("ContactCompanyID");
            entity.Property(e => e.DefaultActUser).HasColumnName("Default_ACT_User");
            entity.Property(e => e.OriginalDescription).HasColumnName("Original_Description");
            entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");

            entity.HasOne(d => d.Account).WithMany(p => p.FinalTransactions)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK_Transactions_Transactions");
        });

        modelBuilder.Entity<Form>(entity =>
        {
            entity.HasKey(e => e.FormId).HasFillFactor(90);

            entity.Property(e => e.FormName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FormSequence>(entity =>
        {
            entity.HasKey(e => e.FormSequenceId).HasFillFactor(90);

            entity.ToTable("FormSequence");

            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.FormSequences)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormSequence_AspNetUsers");
        });

        modelBuilder.Entity<Gfkproduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GFKProducts");

            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Creationdate)
                .HasColumnType("datetime")
                .HasColumnName("creationdate");
            entity.Property(e => e.Equivalency).HasColumnName("equivalency");
            entity.Property(e => e.Isaccessory).HasColumnName("isaccessory");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
            entity.Property(e => e.Lastupdated)
                .HasColumnType("datetime")
                .HasColumnName("lastupdated");
            entity.Property(e => e.Manufacturerid).HasColumnName("manufacturerid");
            entity.Property(e => e.Mfgpartno)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("mfgpartno");
            entity.Property(e => e.Modifieddate)
                .HasColumnType("datetime")
                .HasColumnName("modifieddate");
            entity.Property(e => e.Productid).HasColumnName("productid");
        });

        modelBuilder.Entity<GfkproductView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("GFKProductViews");

            entity.Property(e => e.ItemCode)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Manufacturerid).HasColumnName("manufacturerid");
            entity.Property(e => e.ProductName)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.Productimage).HasMaxLength(68);
        });

        modelBuilder.Entity<Instruction>(entity =>
        {
            entity.Property(e => e.InstructionId).HasColumnName("InstructionID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.InsHeading).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(128);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("InvoiceLog"));

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ExternalInvoiceNo)
                .HasMaxLength(50)
                .HasColumnName("ExternalInvoiceNO");
            entity.Property(e => e.FeesAndCharges).HasColumnType("money");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceSubTotal).HasColumnType("money");
            entity.Property(e => e.InvoiceTotal).HasColumnType("money");
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.SaleInvoiceIdId).HasColumnName("Sale_InvoiceIdID");
            entity.Property(e => e.ShipToContactId).HasColumnName("ShipToContactID");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.TrackingInfo).HasMaxLength(200);

            entity.HasOne(d => d.Company).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Invoices_Companys");

            entity.HasOne(d => d.Contact).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_Invoices_ContactCompany");

            entity.HasOne(d => d.Employee).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Invoices_Employees");

            entity.HasOne(d => d.InvoiceStageNavigation).WithMany(p => p.InvoiceInvoiceStageNavigations)
                .HasForeignKey(d => d.InvoiceStage)
                .HasConstraintName("FK_Invoices_Lists");

            entity.HasOne(d => d.ShipToContact).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.ShipToContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Invoices_Contacts");

            entity.HasOne(d => d.ShipViaNavigation).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.ShipVia)
                .HasConstraintName("FK_Invoices_Shippers");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.InvoiceStatusNavigations)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Invoices_Lists1");
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("InvoiceDetailsLog"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.QuoteId).HasColumnName("QuoteID");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_InvoiceDetails_Invoices");

            entity.HasOne(d => d.Product).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceDetails_Products");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.PurchaseOrderId)
                .HasConstraintName("FK_InvoiceDetails_PurchaseOrdersDetails");

            entity.HasOne(d => d.Quote).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.QuoteId)
                .HasConstraintName("FK_InvoiceDetails_QuoteDetails");
        });

        modelBuilder.Entity<Issue>(entity =>
        {
            entity.HasKey(e => e.IssueId).HasFillFactor(90);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("NewTaskEmail");
                    tb.HasTrigger("UpdateLogs");
                });

            entity.Property(e => e.IssueId).HasColumnName("IssueID");
            entity.Property(e => e.AssignedBy).HasMaxLength(128);
            entity.Property(e => e.AssignedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AssingedToEmpId)
                .HasMaxLength(128)
                .HasColumnName("AssingedToEmpID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompletedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.DueDate)
                .HasDefaultValueSql("(getdate()+(3))")
                .HasColumnType("datetime");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(128)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.IsMyDay).HasColumnType("datetime");
            entity.Property(e => e.OpenDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Priority).HasMaxLength(50);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

            entity.HasOne(d => d.AssignedByNavigation).WithMany(p => p.IssueAssignedByNavigations)
                .HasForeignKey(d => d.AssignedBy)
                .HasConstraintName("FK_Issues_AspNetUsers3");

            entity.HasOne(d => d.AssingedToEmp).WithMany(p => p.IssueAssingedToEmps)
                .HasForeignKey(d => d.AssingedToEmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Issues_AspNetUsers1");

            entity.HasOne(d => d.Category).WithMany(p => p.Issues)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Issues_IssueCategory");

            entity.HasOne(d => d.CompletedByNavigation).WithMany(p => p.IssueCompletedByNavigations)
                .HasForeignKey(d => d.CompletedBy)
                .HasConstraintName("FK_Issues_AspNetUsers2");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.IssueCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_Issues_AspNetUsers4");

            entity.HasOne(d => d.Employee).WithMany(p => p.IssueEmployees)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Issues_AspNetUsers");
        });

        modelBuilder.Entity<IssueCategory>(entity =>
        {
            entity.HasKey(e => e.IssueCategoryId).HasFillFactor(90);

            entity.ToTable("IssueCategory");

            entity.Property(e => e.IssueCategoryId).HasColumnName("IssueCategoryID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
        });

        modelBuilder.Entity<IssueNote>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasFillFactor(90);

            entity.Property(e => e.NoteId).HasColumnName("NoteID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.IsRead).HasDefaultValue(false);
            entity.Property(e => e.IssueId).HasColumnName("IssueID");

            entity.HasOne(d => d.HstryUser).WithMany(p => p.IssueNotes)
                .HasForeignKey(d => d.HstryUserId)
                .HasConstraintName("FK_IssueNotes_AspNetUsers");

            entity.HasOne(d => d.Issue).WithMany(p => p.IssueNotes)
                .HasForeignKey(d => d.IssueId)
                .HasConstraintName("FK_IssueNotes_Issues");
        });

        modelBuilder.Entity<IssueNoteReply>(entity =>
        {
            entity.HasKey(e => e.NotesReplyId).HasFillFactor(90);

            entity.ToTable("IssueNoteReply");

            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsRead).HasDefaultValue(false);
            entity.Property(e => e.NoteId).HasColumnName("NoteID");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.Note).WithMany(p => p.IssueNoteReplies)
                .HasForeignKey(d => d.NoteId)
                .HasConstraintName("FK_IssueNoteReply_IssueNotes");

            entity.HasOne(d => d.User).WithMany(p => p.IssueNoteReplies)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_IssueNoteReply_AspNetUsers");
        });

        modelBuilder.Entity<IssueSubCategory>(entity =>
        {
            entity.HasKey(e => e.IssueSubCategoryId).HasFillFactor(90);

            entity.ToTable("IssueSubCategory");

            entity.Property(e => e.IssueSubCategoryId).HasColumnName("IssueSubCategoryID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.IssueCategoryId).HasColumnName("IssueCategoryID");

            entity.HasOne(d => d.IssueCategory).WithMany(p => p.IssueSubCategories)
                .HasForeignKey(d => d.IssueCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IssueSubCategory_IssueCategory");
        });

        modelBuilder.Entity<Issuebackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Issuebackup");

            entity.Property(e => e.AssingedToEmpId).HasColumnName("AssingedToEmpID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.IssueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("IssueID");
            entity.Property(e => e.OpenDate).HasColumnType("datetime");
            entity.Property(e => e.Priority).HasMaxLength(50);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
        });

        modelBuilder.Entity<Jan2020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Jan2020");

            entity.Property(e => e.AmountDue)
                .HasMaxLength(50)
                .HasColumnName("Amount_Due");
            entity.Property(e => e.Column12)
                .HasMaxLength(50)
                .HasColumnName("Column_12");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Customer).HasMaxLength(50);
            entity.Property(e => e.InvoiceDate).HasColumnName("Invoice_Date");
            entity.Property(e => e.InvoiceId)
                .HasMaxLength(50)
                .HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(50)
                .HasColumnName("Invoice_Number");
            entity.Property(e => e.Issued).HasMaxLength(50);
            entity.Property(e => e.ReferencePoNumber)
                .HasMaxLength(50)
                .HasColumnName("Reference_PO_Number");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TotalDue)
                .HasMaxLength(50)
                .HasColumnName("Total_Due");
        });

        modelBuilder.Entity<LeaveRequestDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmpId).HasColumnName("EmpID");
            entity.Property(e => e.LeaveDetails).HasMaxLength(150);

            entity.HasOne(d => d.Emp).WithMany(p => p.LeaveRequestDetails)
                .HasForeignKey(d => d.EmpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveRequestDetails_Employees");

            entity.HasOne(d => d.LeaveStatusNavigation).WithMany(p => p.LeaveRequestDetails)
                .HasForeignKey(d => d.LeaveStatus)
                .HasConstraintName("FK_LeaveRequestDetails_Lists");

            entity.HasOne(d => d.LeaveType).WithMany(p => p.LeaveRequestDetails)
                .HasForeignKey(d => d.LeaveTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LeaveRequestDetails_LeaveType_List");
        });

        modelBuilder.Entity<LeaveTypeList>(entity =>
        {
            entity.HasKey(e => e.HId);

            entity.ToTable("LeaveType_List");

            entity.Property(e => e.HId).HasColumnName("H_Id");
            entity.Property(e => e.LeaveType)
                .HasMaxLength(50)
                .HasColumnName("Leave_Type");
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => e.ListId).HasFillFactor(90);

            entity.Property(e => e.ListId).HasColumnName("ListID");
            entity.Property(e => e.ListName).HasMaxLength(50);
            entity.Property(e => e.ListValue).HasMaxLength(50);
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.LogId).HasFillFactor(90);

            entity.Property(e => e.LogId)
                .HasMaxLength(128)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("LogID");
            entity.Property(e => e.Action).HasMaxLength(50);
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.HostName).HasMaxLength(150);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("IPAddress");
            entity.Property(e => e.LogDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MachineName)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(150);
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                .HasName("PK_dbo.__MigrationHistory")
                .HasFillFactor(90);

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Newtransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("newtransaction");

            entity.Property(e => e.AccountId).HasColumnName("Account_Id");
            entity.Property(e => e.AccountType).HasColumnName("Account_Type");
            entity.Property(e => e.AddedBy).HasColumnName("Added_by");
            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("Added_Date");
            entity.Property(e => e.DefaultActUser).HasColumnName("Default_ACT_User");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.OriginalDescription).HasColumnName("Original_Description");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasFillFactor(90);

            entity.Property(e => e.NoteId).HasColumnName("NoteID");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

            entity.HasOne(d => d.Form).WithMany(p => p.Notes)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notes_Forms");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasFillFactor(90);

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Freight)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderTotal).HasColumnType("money");
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.ShipToId).HasColumnName("ShipToID");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrderApi>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasFillFactor(90);

            entity.ToTable("OrderApi");

            entity.Property(e => e.BaseHandlingCost).HasColumnName("base_handling_cost");
            entity.Property(e => e.BaseShippingCost).HasColumnName("base_shipping_cost");
            entity.Property(e => e.BaseWrappingCost).HasColumnName("base_wrapping_cost");
            entity.Property(e => e.BillingAddressCity).HasColumnName("billing_address_city");
            entity.Property(e => e.BillingAddressCompany).HasColumnName("billing_address_company");
            entity.Property(e => e.BillingAddressCountry).HasColumnName("billing_address_country");
            entity.Property(e => e.BillingAddressCountryIso2).HasColumnName("billing_address_country_iso2");
            entity.Property(e => e.BillingAddressEmail).HasColumnName("billing_address_email");
            entity.Property(e => e.BillingAddressFirstName).HasColumnName("billing_address_first_name");
            entity.Property(e => e.BillingAddressFormFields).HasColumnName("billing_address_form_fields");
            entity.Property(e => e.BillingAddressLastName).HasColumnName("billing_address_last_name");
            entity.Property(e => e.BillingAddressPhone).HasColumnName("billing_address_phone");
            entity.Property(e => e.BillingAddressState).HasColumnName("billing_address_state");
            entity.Property(e => e.BillingAddressStreet1).HasColumnName("billing_address_street_1");
            entity.Property(e => e.BillingAddressStreet2).HasColumnName("billing_address_street_2");
            entity.Property(e => e.BillingAddressZip).HasColumnName("billing_address_zip");
            entity.Property(e => e.CartId).HasColumnName("cart_id");
            entity.Property(e => e.ChannelId).HasColumnName("channel_id");
            entity.Property(e => e.CouponDiscount).HasColumnName("coupon_discount");
            entity.Property(e => e.CouponsResource).HasColumnName("coupons_resource");
            entity.Property(e => e.CouponsUrl).HasColumnName("coupons_url");
            entity.Property(e => e.CreditCardType).HasColumnName("credit_card_type");
            entity.Property(e => e.CurrencyCode).HasColumnName("currency_code");
            entity.Property(e => e.CurrencyExchangeRate).HasColumnName("currency_exchange_rate");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.CustomStatus).HasColumnName("custom_status");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerLocale).HasColumnName("customer_locale");
            entity.Property(e => e.CustomerMessage).HasColumnName("customer_message");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.DateModified).HasColumnName("date_modified");
            entity.Property(e => e.DateShipped).HasColumnName("date_shipped");
            entity.Property(e => e.DefaultCurrencyCode).HasColumnName("default_currency_code");
            entity.Property(e => e.DefaultCurrencyId).HasColumnName("default_currency_id");
            entity.Property(e => e.DiscountAmount).HasColumnName("discount_amount");
            entity.Property(e => e.EbayOrderId).HasColumnName("ebay_order_id");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(1)
                .HasColumnName("external_id");
            entity.Property(e => e.ExternalMerchantId).HasColumnName("external_merchant_id");
            entity.Property(e => e.ExternalSource).HasColumnName("external_source");
            entity.Property(e => e.GeoipCountry).HasColumnName("geoip_country");
            entity.Property(e => e.GeoipCountryIso2).HasColumnName("geoip_country_iso2");
            entity.Property(e => e.GiftCertificateAmount).HasColumnName("gift_certificate_amount");
            entity.Property(e => e.HandlingCostExTax).HasColumnName("handling_cost_ex_tax");
            entity.Property(e => e.HandlingCostIncTax).HasColumnName("handling_cost_inc_tax");
            entity.Property(e => e.HandlingCostTax).HasColumnName("handling_cost_tax");
            entity.Property(e => e.HandlingCostTaxClassId).HasColumnName("handling_cost_tax_class_id");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.IsEmailOptIn).HasColumnName("is_email_opt_in");
            entity.Property(e => e.ItemsShipped).HasColumnName("items_shipped");
            entity.Property(e => e.ItemsTotal).HasColumnName("items_total");
            entity.Property(e => e.OrderIsDigital).HasColumnName("order_is_digital");
            entity.Property(e => e.OrderSource).HasColumnName("order_source");
            entity.Property(e => e.PaymentMethod).HasColumnName("payment_method");
            entity.Property(e => e.PaymentProviderId).HasColumnName("payment_provider_id");
            entity.Property(e => e.PaymentStatus).HasColumnName("payment_status");
            entity.Property(e => e.ProductsResource).HasColumnName("products_resource");
            entity.Property(e => e.ProductsUrl).HasColumnName("products_url");
            entity.Property(e => e.RefundedAmount).HasColumnName("refunded_amount");
            entity.Property(e => e.ShippingAddressCount).HasColumnName("shipping_address_count");
            entity.Property(e => e.ShippingAddressesResource).HasColumnName("shipping_addresses_resource");
            entity.Property(e => e.ShippingAddressesUrl).HasColumnName("shipping_addresses_url");
            entity.Property(e => e.ShippingCostExTax).HasColumnName("shipping_cost_ex_tax");
            entity.Property(e => e.ShippingCostIncTax).HasColumnName("shipping_cost_inc_tax");
            entity.Property(e => e.ShippingCostTax).HasColumnName("shipping_cost_tax");
            entity.Property(e => e.ShippingCostTaxClassId).HasColumnName("shipping_cost_tax_class_id");
            entity.Property(e => e.StaffNotes).HasColumnName("staff_notes");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.StoreCreditAmount).HasColumnName("store_credit_amount");
            entity.Property(e => e.StoreDefaultCurrencyCode).HasColumnName("store_default_currency_code");
            entity.Property(e => e.StoreDefaultToTransactionalExchangeRate).HasColumnName("store_default_to_transactional_exchange_rate");
            entity.Property(e => e.SubtotalExTax).HasColumnName("subtotal_ex_tax");
            entity.Property(e => e.SubtotalIncTax).HasColumnName("subtotal_inc_tax");
            entity.Property(e => e.SubtotalTax).HasColumnName("subtotal_tax");
            entity.Property(e => e.TaxProviderId).HasColumnName("tax_provider_id");
            entity.Property(e => e.TotalExTax).HasColumnName("total_ex_tax");
            entity.Property(e => e.TotalIncTax).HasColumnName("total_inc_tax");
            entity.Property(e => e.TotalTax).HasColumnName("total_tax");
            entity.Property(e => e.WrappingCostExTax).HasColumnName("wrapping_cost_ex_tax");
            entity.Property(e => e.WrappingCostIncTax).HasColumnName("wrapping_cost_inc_tax");
            entity.Property(e => e.WrappingCostTax).HasColumnName("wrapping_cost_tax");
            entity.Property(e => e.WrappingCostTaxClassId).HasColumnName("wrapping_cost_tax_class_id");
        });

        modelBuilder.Entity<OrderProduct>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasFillFactor(90);

            entity.ToTable("OrderProduct");

            entity.Property(e => e.BaseCostPrice).HasColumnName("base_cost_price");
            entity.Property(e => e.BasePrice).HasColumnName("base_price");
            entity.Property(e => e.BaseTotal).HasColumnName("base_total");
            entity.Property(e => e.BaseWrappingCost).HasColumnName("base_wrapping_cost");
            entity.Property(e => e.BinPickingNumber)
                .IsUnicode(false)
                .HasColumnName("bin_picking_number");
            entity.Property(e => e.CostPriceExTax).HasColumnName("cost_price_ex_tax");
            entity.Property(e => e.CostPriceIncTax).HasColumnName("cost_price_inc_tax");
            entity.Property(e => e.CostPriceTax).HasColumnName("cost_price_tax");
            entity.Property(e => e.Depth).HasColumnName("depth");
            entity.Property(e => e.EbayItemId)
                .IsUnicode(false)
                .HasColumnName("ebay_item_id");
            entity.Property(e => e.EbayTransactionId)
                .IsUnicode(false)
                .HasColumnName("ebay_transaction_id");
            entity.Property(e => e.EventDate)
                .IsUnicode(false)
                .HasColumnName("event_date");
            entity.Property(e => e.EventName)
                .IsUnicode(false)
                .HasColumnName("event_name");
            entity.Property(e => e.ExternalId)
                .IsUnicode(false)
                .HasColumnName("external_id");
            entity.Property(e => e.FixedShippingCost).HasColumnName("fixed_shipping_cost");
            entity.Property(e => e.FulfillmentSource)
                .IsUnicode(false)
                .HasColumnName("fulfillment_source");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsBundledProduct).HasColumnName("is_bundled_product");
            entity.Property(e => e.IsRefunded).HasColumnName("is_refunded");
            entity.Property(e => e.Name)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.NameCustomer)
                .IsUnicode(false)
                .HasColumnName("name_customer");
            entity.Property(e => e.NameMerchant)
                .IsUnicode(false)
                .HasColumnName("name_merchant");
            entity.Property(e => e.OptionSetId)
                .IsUnicode(false)
                .HasColumnName("option_set_id");
            entity.Property(e => e.OrderAddressId).HasColumnName("order_address_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ParentOrderProductId)
                .IsUnicode(false)
                .HasColumnName("parent_order_product_id");
            entity.Property(e => e.PriceExTax).HasColumnName("price_ex_tax");
            entity.Property(e => e.PriceIncTax).HasColumnName("price_inc_tax");
            entity.Property(e => e.PriceTax).HasColumnName("price_tax");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.QuantityRefunded).HasColumnName("quantity_refunded");
            entity.Property(e => e.QuantityShipped).HasColumnName("quantity_shipped");
            entity.Property(e => e.RefundAmount).HasColumnName("refund_amount");
            entity.Property(e => e.ReturnId).HasColumnName("return_id");
            entity.Property(e => e.Sku)
                .IsUnicode(false)
                .HasColumnName("sku");
            entity.Property(e => e.TotalExTax).HasColumnName("total_ex_tax");
            entity.Property(e => e.TotalIncTax).HasColumnName("total_inc_tax");
            entity.Property(e => e.TotalTax).HasColumnName("total_tax");
            entity.Property(e => e.Type)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Upc)
                .IsUnicode(false)
                .HasColumnName("upc");
            entity.Property(e => e.VariantId).HasColumnName("variant_id");
            entity.Property(e => e.Weight).HasColumnName("weight");
            entity.Property(e => e.Width).HasColumnName("width");
            entity.Property(e => e.WrappingCostExTax).HasColumnName("wrapping_cost_ex_tax");
            entity.Property(e => e.WrappingCostIncTax).HasColumnName("wrapping_cost_inc_tax");
            entity.Property(e => e.WrappingCostTax).HasColumnName("wrapping_cost_tax");
            entity.Property(e => e.WrappingMessage)
                .IsUnicode(false)
                .HasColumnName("wrapping_message");
            entity.Property(e => e.WrappingName)
                .IsUnicode(false)
                .HasColumnName("wrapping_name");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.PartnerId)
                .HasName("PK__Partners__39FD633237D7D75B")
                .HasFillFactor(90);

            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.ChangeDate).HasColumnType("datetime");
            entity.Property(e => e.ChangedBy).HasMaxLength(128);
            entity.Property(e => e.City).HasMaxLength(40);
            entity.Property(e => e.ContactCompanyId).HasColumnName("ContactCompanyID");
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(80);
            entity.Property(e => e.Industry).HasMaxLength(100);
            entity.Property(e => e.MinDealValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PartnerShipType).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(40);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.Website).HasMaxLength(255);

            entity.HasOne(d => d.ContactCompany).WithMany(p => p.Partners)
                .HasForeignKey(d => d.ContactCompanyId)
                .HasConstraintName("FK_Partners_ContactCompany");
        });

        modelBuilder.Entity<PartnerCertificate>(entity =>
        {
            entity.HasKey(e => e.CertificateId)
                .HasName("PK__PartnerC__BBF8A7E146BBD4EC")
                .HasFillFactor(90);

            entity.Property(e => e.CertificateId).HasColumnName("CertificateID");
            entity.Property(e => e.CertificateDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CertificateName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CertificateNumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IssuedToName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

            entity.HasOne(d => d.Training).WithMany(p => p.PartnerCertificates)
                .HasForeignKey(d => d.TrainingId)
                .HasConstraintName("FK__PartnerCe__Train__44C1AC7D");
        });

        modelBuilder.Entity<PartnerContact>(entity =>
        {
            entity.HasKey(e => e.ContactId)
                .HasName("PK__PartnerC__5C6625BB9F2B367D")
                .HasFillFactor(90);

            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AddressLine2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ContactRole)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PostalCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnerContacts)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK__PartnerCo__Partn__04F074D4");
        });

        modelBuilder.Entity<PartnerDealRegistration>(entity =>
        {
            entity.HasKey(e => e.DealRegId)
                .HasName("PK__PartnerD__64D309B561D1EA68")
                .HasFillFactor(90);

            entity.ToTable("PartnerDealRegistration");

            entity.Property(e => e.DealRegId).HasColumnName("DealRegID");
            entity.Property(e => e.ChangedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");

            entity.HasOne(d => d.Opportunity).WithMany(p => p.PartnerDealRegistrations)
                .HasForeignKey(d => d.OpportunityId)
                .HasConstraintName("FK__PartnerDe__Oppor__46A9F4EF");
        });

        modelBuilder.Entity<PartnerLogin>(entity =>
        {
            entity.HasKey(e => e.LoginId)
                .HasName("PK__PartnerL__4DDA2838681CE88C")
                .HasFillFactor(90);

            entity.Property(e => e.LoginId).HasColumnName("LoginID");
            entity.Property(e => e.LoginUrl)
                .IsUnicode(false)
                .HasColumnName("LoginURL");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnerLogins)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK__PartnerLo__Partn__05E4990D");
        });

        modelBuilder.Entity<PartnerOpportunity>(entity =>
        {
            entity.HasKey(e => e.OpportunityId)
                .HasName("PK__PartnerO__0034EDB10C384AC5")
                .HasFillFactor(90);

            entity.ToTable("PartnerOpportunity");

            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");
            entity.Property(e => e.ChangedBy).HasMaxLength(128);
            entity.Property(e => e.CloseDate).HasColumnType("datetime");
            entity.Property(e => e.CoTermQuoteId)
                .HasMaxLength(255)
                .HasColumnName("CoTermQuoteID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DealRegOot).HasColumnName("DealRegOOT");
            entity.Property(e => e.DealType).HasMaxLength(100);
            entity.Property(e => e.EstimatedValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FortiCareId)
                .HasMaxLength(255)
                .HasColumnName("FortiCareID");
            entity.Property(e => e.IsOperationalTechnologyOpportunity).HasMaxLength(50);
            entity.Property(e => e.IsSdwanopportunity).HasColumnName("IsSDWANOpportunity");
            entity.Property(e => e.OpportunityName).HasMaxLength(255);
            entity.Property(e => e.OpportunityType).HasMaxLength(100);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.SerialNumber).HasMaxLength(255);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.TradeUpId)
                .HasMaxLength(255)
                .HasColumnName("TradeUpID");

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnerOpportunities)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK__PartnerOp__Partn__73C5E8D2");
        });

        modelBuilder.Entity<PartnerOpportunityHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId)
                .HasName("PK__PartnerO__4D7B4ADD150DC0B6")
                .HasFillFactor(90);

            entity.ToTable("PartnerOpportunityHistory");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.ChangedBy).HasMaxLength(128);
            entity.Property(e => e.ChangedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OpportunityId).HasColumnName("OpportunityID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.Opportunity).WithMany(p => p.PartnerOpportunityHistories)
                .HasForeignKey(d => d.OpportunityId)
                .HasConstraintName("FK__PartnerOp__Oppor__4986619A");

            entity.HasOne(d => d.Status).WithMany(p => p.PartnerOpportunityHistories)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK__PartnerOp__Statu__4A7A85D3");
        });

        modelBuilder.Entity<PartnerOpportunityStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId)
                .HasName("PK__PartnerO__C8EE20432410D70C")
                .HasFillFactor(90);

            entity.ToTable("PartnerOpportunityStatus");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.ChangedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.StatusName).HasMaxLength(100);
        });

        modelBuilder.Entity<PartnerProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId)
                .HasName("PK__PartnerP__B40CC6ED4C017595")
                .HasFillFactor(90);

            entity.ToTable("PartnerProduct");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ChangedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductCategory).HasMaxLength(100);
            entity.Property(e => e.ProductCode).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(255);
        });

        modelBuilder.Entity<PartnerTraining>(entity =>
        {
            entity.HasKey(e => e.TrainingId)
                .HasName("PK__PartnerT__E8D71DE20750BF31")
                .HasFillFactor(90);

            entity.Property(e => e.TrainingId).HasColumnName("TrainingID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.TrainingName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TrainingType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnerTrainings)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK__PartnerTr__Partn__06D8BD46");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasFillFactor(90);

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.HstryDateTime)
                .IsRowVersion()
                .IsConcurrencyToken();
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.Method).HasMaxLength(50);
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.Reference).HasMaxLength(50);
        });

        modelBuilder.Entity<PaymentMade>(entity =>
        {
            entity.HasKey(e => e.PaymentMadeId).HasFillFactor(90);

            entity.ToTable("PaymentMade");

            entity.Property(e => e.PaymentMadeId).HasColumnName("PaymentMadeID");
            entity.Property(e => e.AccountNameId).HasColumnName("AccountNameID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactCompanyId).HasColumnName("ContactCompanyID");
            entity.Property(e => e.DateReceived).HasColumnName("Date_Received");
            entity.Property(e => e.FinalTransactionId).HasColumnName("FinalTransactionID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.MethodId).HasColumnName("MethodID");

            entity.HasOne(d => d.AccountName).WithMany(p => p.PaymentMades)
                .HasForeignKey(d => d.AccountNameId)
                .HasConstraintName("FK_PaymentMade_Accountname");

            entity.HasOne(d => d.Company).WithMany(p => p.PaymentMades)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_PaymentMade_Companys");

            entity.HasOne(d => d.ContactCompany).WithMany(p => p.PaymentMades)
                .HasForeignKey(d => d.ContactCompanyId)
                .HasConstraintName("FK_PaymentMade_ContactCompany");

            entity.HasOne(d => d.FinalTransaction).WithMany(p => p.PaymentMades)
                .HasForeignKey(d => d.FinalTransactionId)
                .HasConstraintName("FK_PaymentMade_Final_Transactions");

            entity.HasOne(d => d.Method).WithMany(p => p.PaymentMades)
                .HasForeignKey(d => d.MethodId)
                .HasConstraintName("FK_PaymentMade_PaymentTerms");
        });

        modelBuilder.Entity<PaymentMadeBill>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("PaymentMade_Bills");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BillsId).HasColumnName("BillsID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.PaymentMadeId).HasColumnName("PaymentMadeID");

            entity.HasOne(d => d.Bills).WithMany(p => p.PaymentMadeBills)
                .HasForeignKey(d => d.BillsId)
                .HasConstraintName("FK_PaymentMade_Bills_Bills");

            entity.HasOne(d => d.PaymentMade).WithMany(p => p.PaymentMadeBills)
                .HasForeignKey(d => d.PaymentMadeId)
                .HasConstraintName("FK_PaymentMade_Bills_PaymentMade");
        });

        modelBuilder.Entity<PaymentTerm>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasFillFactor(90);

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.HstryDateTime)
                .HasMaxLength(10)
                .HasDefaultValueSql("(getdate())")
                .IsFixedLength();
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.PaymentTerm1)
                .HasMaxLength(50)
                .HasColumnName("PaymentTerm");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Porequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("PORequest");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.HstryDateTime)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");
            entity.Property(e => e.ShipToId).HasColumnName("ShipToID");
            entity.Property(e => e.ShippingCost).HasColumnType("money");
            entity.Property(e => e.VendorId).HasColumnName("VendorID");

            entity.HasOne(d => d.Customer).WithMany(p => p.PorequestCustomers)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_PORequest_ContactCompany");

            entity.HasOne(d => d.PoCompanyNavigation).WithMany(p => p.Porequests)
                .HasForeignKey(d => d.PoCompany)
                .HasConstraintName("FK_PORequest_EmployeeCompanies");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.Porequests)
                .HasForeignKey(d => d.PurchaseOrderId)
                .HasConstraintName("FK_PORequest_PurchaseOrders");

            entity.HasOne(d => d.ShipTo).WithMany(p => p.Porequests)
                .HasForeignKey(d => d.ShipToId)
                .HasConstraintName("FK_PORequest_Contacts");

            entity.HasOne(d => d.ShipViaNavigation).WithMany(p => p.Porequests)
                .HasForeignKey(d => d.ShipVia)
                .HasConstraintName("FK_PORequest_Shippers");

            entity.HasOne(d => d.Vendor).WithMany(p => p.PorequestVendors)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK_PORequest_Contacts1");
        });

        modelBuilder.Entity<PorequestDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("PORequestDetails");

            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.PorequestId).HasColumnName("PORequestId");
            entity.Property(e => e.PriceQuoted).HasColumnType("money");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Porequest).WithMany(p => p.PorequestDetails)
                .HasForeignKey(d => d.PorequestId)
                .HasConstraintName("FK_PORequestDetails_PORequest");

            entity.HasOne(d => d.Product).WithMany(p => p.PorequestDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_PORequestDetails_Products");
        });

        modelBuilder.Entity<Presubtotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("presubtotal");

            entity.Property(e => e.QuoteId).HasColumnName("QuoteID");
            entity.Property(e => e.Subtotala).HasColumnName("subtotala");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasFillFactor(90);

            entity.HasIndex(e => e.ItemCode, "IX_Products_Itemcode").HasFillFactor(90);

            entity.HasIndex(e => new { e.ProductId, e.Status, e.ItemCode }, "NonClusteredIndex-20200409-111247").HasFillFactor(90);

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.IsTrackable).HasDefaultValue(true);
            entity.Property(e => e.ItemCode).HasMaxLength(200);
            entity.Property(e => e.Status).HasDefaultValue(4);
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Products_Lists");
        });

        modelBuilder.Entity<ProductImage>(entity =>
        {
            entity.HasKey(e => e.ProductImageId).HasFillFactor(90);

            entity.Property(e => e.ProductImageId).HasColumnName("ProductImageID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.HstryUser).WithMany(p => p.ProductImages)
                .HasForeignKey(d => d.HstryUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductImages_AspNetUsers");
        });

        modelBuilder.Entity<ProductManufacturer>(entity =>
        {
            entity.HasKey(e => e.ManufacturerId).HasFillFactor(90);

            entity.ToTable("ProductManufacturer");

            entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");
            entity.Property(e => e.EtzmanufacturerId).HasColumnName("ETZManufacturerID");
            entity.Property(e => e.EtzproductId).HasColumnName("ETZProductID");
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductManufacturers)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductManufacturer_Products");
        });

        modelBuilder.Entity<ProductsUpload>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductsUpload");

            entity.Property(e => e.GfkproductId).HasColumnName("GFKProductID");
            entity.Property(e => e.ItemCode)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.ProductName)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProfitSharing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProfitSharing");

            entity.Property(e => e.AspnetUserId).HasColumnName("ASPNetUserID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CompanyID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .IsFixedLength()
                .HasColumnName("HstryUserID");
            entity.Property(e => e.ProfitSharingId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ProfitSharingID");
            entity.Property(e => e.SharePercentage)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrdersId).HasFillFactor(90);

            entity.HasIndex(e => e.CompanyId, "NonClusteredIndex-20240408-121757").HasFillFactor(90);

            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ExternalPurchaseOrderNo)
                .HasMaxLength(50)
                .HasColumnName("ExternalPurchaseOrderNO");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.PurchaseOrdersDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrdersSubTotal).HasColumnType("money");
            entity.Property(e => e.PurchaseOrdersTotal).HasColumnType("money");
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.ShipToContactId).HasColumnName("ShipToContactID");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");

            entity.HasOne(d => d.Company).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_PurchaseOrders_Companys");

            entity.HasOne(d => d.Contact).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_PurchaseOrders_Contacts");

            entity.HasOne(d => d.Employee).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_PurchaseOrders_Employees");

            entity.HasOne(d => d.PurchaseOrdersStageNavigation).WithMany(p => p.PurchaseOrderPurchaseOrdersStageNavigations)
                .HasForeignKey(d => d.PurchaseOrdersStage)
                .HasConstraintName("FK_PurchaseOrders_Lists");

            entity.HasOne(d => d.ShipToContact).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.ShipToContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrders_Contacts1");

            entity.HasOne(d => d.ShipViaNavigation).WithMany(p => p.PurchaseOrders)
                .HasForeignKey(d => d.ShipVia)
                .HasConstraintName("FK_PurchaseOrders_Shippers");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.PurchaseOrderStatusNavigations)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrders_Lists1");
        });

        modelBuilder.Entity<PurchaseOrdersDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.InvoiceRemainingQuantity).HasColumnType("money");
            entity.Property(e => e.IsLock).HasColumnName("isLock");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.RemainingQuantity).HasColumnType("money");
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.Property(e => e.UserId)
                .HasMaxLength(128)
                .HasColumnName("UserID");

            entity.HasOne(d => d.Product).WithMany(p => p.PurchaseOrdersDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PurchaseOrdersDetails_Products");

            entity.HasOne(d => d.PurchaseOrders).WithMany(p => p.PurchaseOrdersDetails)
                .HasForeignKey(d => d.PurchaseOrdersId)
                .HasConstraintName("FK_PurchaseOrdersDetails_PurchaseOrders");
        });

        modelBuilder.Entity<Quote>(entity =>
        {
            entity.HasKey(e => e.QuoteId).HasFillFactor(90);

            entity.Property(e => e.QuoteId).HasColumnName("QuoteID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.QuoteDate).HasColumnType("datetime");
            entity.Property(e => e.QuoteTotal).HasColumnType("money");
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.ShipToContactId).HasColumnName("ShipToContactID");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            entity.Property(e => e.SubTotal).HasColumnType("money");
            entity.Property(e => e.TaxId).HasColumnName("TaxID");

            entity.HasOne(d => d.Company).WithMany(p => p.Quotes)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Quotes_Companys");

            entity.HasOne(d => d.Contact).WithMany(p => p.Quotes)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_Quotes_Contacts");

            entity.HasOne(d => d.Employee).WithMany(p => p.Quotes)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Quotes_Employees");

            entity.HasOne(d => d.QuoteStageNavigation).WithMany(p => p.QuoteQuoteStageNavigations)
                .HasForeignKey(d => d.QuoteStage)
                .HasConstraintName("FK_Quotes_Lists");

            entity.HasOne(d => d.ShipToContact).WithMany(p => p.Quotes)
                .HasForeignKey(d => d.ShipToContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Quotes_Contacts1");

            entity.HasOne(d => d.ShipViaNavigation).WithMany(p => p.Quotes)
                .HasForeignKey(d => d.ShipVia)
                .HasConstraintName("FK_Quotes_Shippers");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.QuoteStatusNavigations)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Quotes_Lists1");
        });

        modelBuilder.Entity<QuoteDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Quantity).HasColumnType("money");
            entity.Property(e => e.QuoteId).HasColumnName("QuoteID");
            entity.Property(e => e.RemainingQuantity).HasColumnType("money");
            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Product).WithMany(p => p.QuoteDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuoteDetails_Products");

            entity.HasOne(d => d.Quote).WithMany(p => p.QuoteDetails)
                .HasForeignKey(d => d.QuoteId)
                .HasConstraintName("FK_QuoteDetails_Quotes");
        });

        modelBuilder.Entity<RealTimeProductSearchAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("RealTimeProductSearchAccount");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountCompanyName).HasMaxLength(100);
            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.CustomerNo)
                .HasMaxLength(100)
                .HasColumnName("customerNo");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<Receipt>(entity =>
        {
            entity.HasKey(e => e.ReceiptId).HasFillFactor(90);

            entity.ToTable("Receipt");

            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");
            entity.Property(e => e.AccountNameId).HasColumnName("AccountNameID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ContactCompanyId).HasColumnName("ContactCompanyID");
            entity.Property(e => e.DateReceived).HasColumnName("Date_Received");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FinalTransactionId).HasColumnName("FinalTransactionID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.MethodId).HasColumnName("MethodID");

            entity.HasOne(d => d.AccountName).WithMany(p => p.Receipts)
                .HasForeignKey(d => d.AccountNameId)
                .HasConstraintName("FK_Receipt_Accountname");

            entity.HasOne(d => d.Company).WithMany(p => p.Receipts)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_Receipt_Companys");

            entity.HasOne(d => d.ContactCompany).WithMany(p => p.Receipts)
                .HasForeignKey(d => d.ContactCompanyId)
                .HasConstraintName("FK_Receipt_ContactCompany");

            entity.HasOne(d => d.FinalTransaction).WithMany(p => p.Receipts)
                .HasForeignKey(d => d.FinalTransactionId)
                .HasConstraintName("FK_Receipt_Final_Transactions");

            entity.HasOne(d => d.Method).WithMany(p => p.Receipts)
                .HasForeignKey(d => d.MethodId)
                .HasConstraintName("FK_Receipt_PaymentTerms");
        });

        modelBuilder.Entity<ReceiptInvoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Receipt_Invoices");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");

            entity.HasOne(d => d.Invoice).WithMany(p => p.ReceiptInvoices)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_Receipt_Invoices_Invoices");

            entity.HasOne(d => d.Receipt).WithMany(p => p.ReceiptInvoices)
                .HasForeignKey(d => d.ReceiptId)
                .HasConstraintName("FK_Receipt_Invoices_Receipt");
        });

        modelBuilder.Entity<RelatedProduct>(entity =>
        {
            entity.HasKey(e => e.RelatedProductId).HasFillFactor(90);

            entity.Property(e => e.RelatedProductId).HasColumnName("RelatedProductID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RelatedProduct1).HasColumnName("RelatedProduct");

            entity.HasOne(d => d.HstryUser).WithMany(p => p.RelatedProducts)
                .HasForeignKey(d => d.HstryUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelatedProducts_AspNetUsers");
        });

        modelBuilder.Entity<ResponsibilityUser>(entity =>
        {
            entity.HasKey(e => e.TaskUserId);

            entity.ToTable("ResponsibilityUser");

            entity.Property(e => e.TaskUserId).HasColumnName("TaskUserID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.TaskResponsibilityId).HasColumnName("TaskResponsibilityID");

            entity.HasOne(d => d.Employee).WithMany(p => p.ResponsibilityUsers)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_ResponsibilityUser_Employees");

            entity.HasOne(d => d.TaskResponsibility).WithMany(p => p.ResponsibilityUsers)
                .HasForeignKey(d => d.TaskResponsibilityId)
                .HasConstraintName("FK_ResponsibilityUser_TaskResponsibility");
        });

        modelBuilder.Entity<Rma>(entity =>
        {
            entity.HasKey(e => e.Rmaid).HasFillFactor(90);

            entity.ToTable("RMA");

            entity.Property(e => e.Rmaid).HasColumnName("RMAID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetailID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.SerialNo).HasMaxLength(100);

            entity.HasOne(d => d.HstryUser).WithMany(p => p.Rmas)
                .HasForeignKey(d => d.HstryUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RMA_AspNetUsers");

            entity.HasOne(d => d.Invoice).WithMany(p => p.Rmas)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_RMA_Invoices");
        });

        modelBuilder.Entity<RoleRight>(entity =>
        {
            entity.HasKey(e => e.RoleRightsId).HasFillFactor(90);

            entity.Property(e => e.AddedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AddedDate).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasMaxLength(128);

            entity.HasOne(d => d.Role).WithMany(p => p.RoleRights)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleRights_AspNetRoles");
        });

        modelBuilder.Entity<Rule>(entity =>
        {
            entity.HasKey(e => e.RuleId).HasFillFactor(90);

            entity.Property(e => e.RuleId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("RuleID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RunFlag).HasDefaultValue(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.AssignToNavigation).WithMany(p => p.Rules)
                .HasForeignKey(d => d.AssignTo)
                .HasConstraintName("FK_Rules_Employees");
        });

        modelBuilder.Entity<SageInvoice>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cost).HasMaxLength(50);
            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(50)
                .HasColumnName("Invoice_No");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Net).HasMaxLength(50);
            entity.Property(e => e.Products).HasMaxLength(300);
            entity.Property(e => e.Profit).HasMaxLength(50);
            entity.Property(e => e.Profit2).HasMaxLength(50);
            entity.Property(e => e.QtyHrs).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UnitPrice)
                .HasMaxLength(50)
                .HasColumnName("Unit_Price");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.ScheduleId).HasFillFactor(90);

            entity.ToTable("Schedule");

            entity.Property(e => e.ScheduleId)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ScheduleID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DaysReq).HasDefaultValue(2);
            entity.Property(e => e.LastRunDate).HasColumnType("datetime");
            entity.Property(e => e.NextRunDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy).HasMaxLength(128);

            entity.HasOne(d => d.AssignedToNavigation).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.AssignedTo)
                .HasConstraintName("FK_Schedule_Employees");
        });

        modelBuilder.Entity<ScheduledProcedure>(entity =>
        {
            entity.HasKey(e => e.ProcedureId)
                .HasName("PK__Schedule__54C2E50D8E7E1F45")
                .HasFillFactor(90);

            entity.Property(e => e.ProcedureId).HasColumnName("ProcedureID");
            entity.Property(e => e.ExecutionTime).HasPrecision(0);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ProcedureName).HasMaxLength(512);
        });

        modelBuilder.Entity<Scheduler>(entity =>
        {
            entity.HasKey(e => e.SchedulerId).HasName("PK_Schedular");

            entity.ToTable("Scheduler");

            entity.Property(e => e.SchedulerId).HasColumnName("SchedulerID");
            entity.Property(e => e.SchedulerMonthDays).HasMaxLength(50);
            entity.Property(e => e.SchedulerMonthId).HasColumnName("SchedulerMonthID");
            entity.Property(e => e.SchedulerWeekId).HasColumnName("SchedulerWeekID");
            entity.Property(e => e.TaskId).HasColumnName("TaskID");

            entity.HasOne(d => d.SchedulerMonth).WithMany(p => p.Schedulers)
                .HasForeignKey(d => d.SchedulerMonthId)
                .HasConstraintName("FK_Scheduler_SchedulerMonths");

            entity.HasOne(d => d.SchedulerWeek).WithMany(p => p.Schedulers)
                .HasForeignKey(d => d.SchedulerWeekId)
                .HasConstraintName("FK_Scheduler_SchedulerWeeks");

            entity.HasOne(d => d.Task).WithMany(p => p.Schedulers)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("FK_Scheduler_TaskResponsibility");
        });

        modelBuilder.Entity<SchedulerMonth>(entity =>
        {
            entity.HasKey(e => e.SchedulerMonthsId).HasName("PK_SchedularMonths");

            entity.Property(e => e.SchedulerMonthsId).HasColumnName("SchedulerMonthsID");
            entity.Property(e => e.SchedulerMonths).HasMaxLength(50);
        });

        modelBuilder.Entity<SchedulerWeek>(entity =>
        {
            entity.HasKey(e => e.SchedulerWeeksId).HasName("PK_SchedularWeeks");

            entity.Property(e => e.SchedulerWeeksId).HasColumnName("SchedulerWeeksID");
            entity.Property(e => e.SchedulerWeeks).HasMaxLength(50);
        });

        modelBuilder.Entity<SessionLog>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasFillFactor(90);

            entity.ToTable("SessionLog");

            entity.Property(e => e.SessionId).HasColumnName("SessionID");
            entity.Property(e => e.ExpireTime).HasColumnType("datetime");
            entity.Property(e => e.FormsId).HasColumnName("FormsID");
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.StartTime).HasColumnType("datetime");
            entity.Property(e => e.TableName).HasMaxLength(100);
        });

        modelBuilder.Entity<ShipTo>(entity =>
        {
            entity.HasKey(e => e.ShipToId)
                .HasName("PK_Shipto")
                .HasFillFactor(90);

            entity.ToTable("ShipTo");

            entity.Property(e => e.ShipToId).HasColumnName("ShipToID");
            entity.Property(e => e.Address1).HasMaxLength(60);
            entity.Property(e => e.Address2).HasMaxLength(60);
            entity.Property(e => e.City).HasMaxLength(15);
            entity.Property(e => e.ContactCompanyId)
                .HasMaxLength(40)
                .HasColumnName("ContactCompanyID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ContactTitle).HasMaxLength(30);
            entity.Property(e => e.Country).HasMaxLength(15);
            entity.Property(e => e.Department).HasMaxLength(40);
            entity.Property(e => e.Extension).HasMaxLength(4);
            entity.Property(e => e.Fax).HasMaxLength(24);
            entity.Property(e => e.FirstName).HasMaxLength(30);
            entity.Property(e => e.HstryDateTime).HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.LastName).HasMaxLength(30);
            entity.Property(e => e.MiddleName).HasMaxLength(30);
            entity.Property(e => e.Mobile).HasMaxLength(24);
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.PostalCode).HasMaxLength(10);
            entity.Property(e => e.Website).HasColumnType("ntext");
        });

        modelBuilder.Entity<ShipmentTracking>(entity =>
        {
            entity.HasKey(e => e.ShipmentTrackignId)
                .HasName("PK_ShipmentTrackign")
                .HasFillFactor(90);

            entity.ToTable("ShipmentTracking");

            entity.Property(e => e.ShipmentTrackignId).HasColumnName("ShipmentTrackignID");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.TrackingNumber).HasMaxLength(128);
            entity.Property(e => e.Urlprefix).HasColumnName("URLPrefix");
        });

        modelBuilder.Entity<Shipper>(entity =>
        {
            entity.HasKey(e => e.ShipperId).HasFillFactor(90);

            entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            entity.Property(e => e.CompanyName).HasMaxLength(40);
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.Phone).HasMaxLength(24);
            entity.Property(e => e.ShippingService).HasMaxLength(50);
        });

        modelBuilder.Entity<StateShippingTax>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StateShippingTax");

            entity.Property(e => e.Abbreviation)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LastUpdated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StateName).HasMaxLength(50);
        });

        modelBuilder.Entity<StoreProcedureList>(entity =>
        {
            entity.HasKey(e => e.StoreProcedureId).HasFillFactor(90);

            entity.ToTable("StoreProcedureList");

            entity.Property(e => e.StoreProcedureId).HasColumnName("StoreProcedureID");
            entity.Property(e => e.DisplayName).HasMaxLength(100);
            entity.Property(e => e.StoreProcedureName).HasMaxLength(100);
        });

        modelBuilder.Entity<StoreProcedureParam>(entity =>
        {
            entity.HasKey(e => e.StoreProcedureIparamD).HasFillFactor(90);

            entity.ToTable("StoreProcedureParam");

            entity.Property(e => e.StoreProcedureIparamD).HasColumnName("StoreProcedureIParamD");
            entity.Property(e => e.ParamName).HasMaxLength(100);
            entity.Property(e => e.ParamValue).HasMaxLength(100);
            entity.Property(e => e.StoreProcedureId).HasColumnName("StoreProcedureID");

            entity.HasOne(d => d.StoreProcedure).WithMany(p => p.StoreProcedureParams)
                .HasForeignKey(d => d.StoreProcedureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoreProcedureParam_ScheduledProcedures");
        });

        modelBuilder.Entity<StripeFee>(entity =>
        {
            entity.HasKey(e => e.StripeFeesId).HasFillFactor(90);

            entity.Property(e => e.StripeFeesId).HasColumnName("StripeFeesID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.Currency)
                .HasMaxLength(100)
                .HasColumnName("currency");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.StripeTransactionId).HasColumnName("StripeTransactionID");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");

            entity.HasOne(d => d.StripeTransaction).WithMany(p => p.StripeFees)
                .HasForeignKey(d => d.StripeTransactionId)
                .HasConstraintName("FK_StripeFees_StripeFees");
        });

        modelBuilder.Entity<StripePayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasFillFactor(90);

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountRefunded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CardId).HasColumnName("CardID");
            entity.Property(e => e.ConvertedAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ConvertedAmountRefunded).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ConvertedCurrency).HasMaxLength(10);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Fee).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.MerchantReference).HasColumnName("merchant_reference");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<StripeTransaction>(entity =>
        {
            entity.HasKey(e => e.StripTransactionId).HasFillFactor(90);

            entity.Property(e => e.StripTransactionId).HasColumnName("StripTransactionID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("amount");
            entity.Property(e => e.AvailableOn)
                .HasColumnType("datetime")
                .HasColumnName("available_on");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Currency)
                .HasMaxLength(50)
                .HasColumnName("currency");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Fee)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("fee");
            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Net)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("net");
            entity.Property(e => e.ReportingCategory)
                .HasMaxLength(100)
                .HasColumnName("reporting_category");
            entity.Property(e => e.Source)
                .HasMaxLength(100)
                .HasColumnName("source");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
            entity.Property(e => e.StripeAccountName).HasMaxLength(100);
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Synnex2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Synnex2024");

            entity.Property(e => e.BatchRefId).HasColumnName("Batch_Ref_ID");
            entity.Property(e => e.Cin)
                .HasMaxLength(1)
                .HasColumnName("CIN");
            entity.Property(e => e.CloseDate).HasColumnName("Close_Date");
            entity.Property(e => e.InvoiceDate).HasColumnName("Invoice_Date");
            entity.Property(e => e.OrderTotal).HasColumnName("Order_Total");
            entity.Property(e => e.PayAmount).HasColumnName("Pay_Amount");
            entity.Property(e => e.PaymentConfirmationId)
                .HasMaxLength(50)
                .HasColumnName("Payment_Confirmation_ID");
            entity.Property(e => e.PaymentDate).HasColumnName("Payment_Date");
            entity.Property(e => e.Po)
                .HasMaxLength(50)
                .HasColumnName("PO");
        });

        modelBuilder.Entity<TableColList>(entity =>
        {
            entity.HasKey(e => e.TableColId).HasFillFactor(90);

            entity.ToTable("TableColList");

            entity.Property(e => e.TableColName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Table).WithMany(p => p.TableColLists)
                .HasForeignKey(d => d.TableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TableColList_Forms");
        });

        modelBuilder.Entity<TaskResponsibility>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK_Task");

            entity.ToTable("TaskResponsibility");

            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.InstructionId).HasColumnName("InstructionID");
            entity.Property(e => e.TaskName).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(128);

            entity.HasOne(d => d.Instruction).WithMany(p => p.TaskResponsibilities)
                .HasForeignKey(d => d.InstructionId)
                .HasConstraintName("FK_TaskResponsibility_Instructions");
        });

        modelBuilder.Entity<TaxRate>(entity =>
        {
            entity.HasKey(e => e.TaxId)
                .HasName("PK_TAXRATES_ZIP5_CA202003")
                .HasFillFactor(90);

            entity.ToTable(tb => tb.HasTrigger("UpdateCityRate"));

            entity.Property(e => e.TaxId).HasColumnName("TaxID");
            entity.Property(e => e.CityAndRate).HasMaxLength(100);
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(50)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.TaxRegionName).HasMaxLength(100);
            entity.Property(e => e.ZipCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TempInvoiceSubtotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempInvoiceSubtotal");

            entity.Property(e => e.Itemtotal).HasColumnType("money");
        });

        modelBuilder.Entity<TempStripeItemized>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempStripeItemized");

            entity.Property(e => e.AutomaticPayoutEffectiveAt)
                .HasColumnType("datetime")
                .HasColumnName("automatic_payout_effective_at");
            entity.Property(e => e.AutomaticPayoutId)
                .HasMaxLength(255)
                .HasColumnName("automatic_payout_id");
            entity.Property(e => e.AvailableOn)
                .HasColumnType("datetime")
                .HasColumnName("available_on");
            entity.Property(e => e.BalanceTransactionId)
                .HasMaxLength(255)
                .HasColumnName("balance_transaction_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasColumnName("currency");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Fee).HasColumnName("fee");
            entity.Property(e => e.Gross).HasColumnName("gross");
            entity.Property(e => e.IsReconcile).HasColumnName("isReconcile");
            entity.Property(e => e.Net).HasColumnName("net");
            entity.Property(e => e.ReportingCategory)
                .HasMaxLength(255)
                .HasColumnName("reporting_category");
            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<TempTransaction>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .HasColumnName("Account_Name");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Labels).HasMaxLength(1);
            entity.Property(e => e.Notes).HasMaxLength(1);
            entity.Property(e => e.OriginalDescription)
                .HasMaxLength(200)
                .HasColumnName("Original_Description");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .HasColumnName("Transaction_Type");
        });

        modelBuilder.Entity<ToolTip>(entity =>
        {
            entity.HasKey(e => e.ToolTipId).HasFillFactor(90);

            entity.ToTable("ToolTip");

            entity.Property(e => e.ToolTipId).HasColumnName("ToolTipID");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(150)
                .HasColumnName("column_name");
            entity.Property(e => e.DataType)
                .HasMaxLength(50)
                .HasColumnName("data_type");
            entity.Property(e => e.FormId).HasColumnName("FormID");
            entity.Property(e => e.TableName)
                .HasMaxLength(150)
                .HasColumnName("TABLE_NAME");

            entity.HasOne(d => d.Form).WithMany(p => p.ToolTips)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ToolTip_Forms");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_RoughTransactions")
                .HasFillFactor(90);

            entity.HasIndex(e => new { e.Id, e.AccountId }, "NonClusteredIndex-20200115-133218").HasFillFactor(90);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId).HasColumnName("Account_Id");
            entity.Property(e => e.AccountType).HasColumnName("Account_Type");
            entity.Property(e => e.AddedBy).HasColumnName("Added_by");
            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("Added_Date");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DefaultActUser).HasColumnName("Default_ACT_User");
            entity.Property(e => e.Enableflag).HasDefaultValue(false);
            entity.Property(e => e.OriginalDescription).HasColumnName("Original_Description");
            entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");

            entity.HasOne(d => d.Account).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("FK_Transactions_Accountname");
        });

        modelBuilder.Entity<TransactionCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Transaction_Category");

            entity.Property(e => e.AddedBy).HasColumnName("Added_by");
            entity.Property(e => e.AddedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Added_Date");
        });

        modelBuilder.Entity<TransactionSubCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(90);

            entity.ToTable("Transaction_SubCategory");

            entity.Property(e => e.AddedBy).HasColumnName("Added_by");
            entity.Property(e => e.AddedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Added_Date");
            entity.Property(e => e.TransectionCategoryId).HasColumnName("Transection_CategoryId");

            entity.HasOne(d => d.TransectionCategory).WithMany(p => p.TransactionSubCategories)
                .HasForeignKey(d => d.TransectionCategoryId)
                .HasConstraintName("FK_Transaction_SubCategory_Transaction_Category");
        });

        modelBuilder.Entity<TransactionsLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasFillFactor(90);

            entity.ToTable("Transactions_Log");

            entity.HasIndex(e => new { e.LogId, e.UserId, e.TransectionId }, "NonClusteredIndex-20200117-182636").HasFillFactor(90);

            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.TransactionsLogs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Transactions_Log_AspNetUsers");
        });

        modelBuilder.Entity<UserRight>(entity =>
        {
            entity.HasKey(e => e.UserRightsId).HasFillFactor(90);

            entity.Property(e => e.AddedBy).HasColumnName("Added_by");
            entity.Property(e => e.AddedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Added_Date");
            entity.Property(e => e.HstryDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.HstryUserId)
                .HasMaxLength(128)
                .HasColumnName("HstryUserID");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.UserRights)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserRights_AspNetUsers");
        });

        modelBuilder.Entity<VersionTable>(entity =>
        {
            entity.HasKey(e => e.VersionId).HasFillFactor(90);

            entity.ToTable("VersionTable");

            entity.Property(e => e.VersionDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewAccountPayableByCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AccountPayableByCompany");

            entity.Property(e => e.TotalBill).HasColumnType("money");
        });

        modelBuilder.Entity<ViewAccountsReceivableByCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AccountsReceivableByCompany");

            entity.Property(e => e.TotalInv).HasColumnType("money");
        });

        modelBuilder.Entity<ViewAdsi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ADSI");

            entity.Property(e => e.Company)
                .HasMaxLength(4000)
                .HasColumnName("company");
            entity.Property(e => e.Department)
                .HasMaxLength(4000)
                .HasColumnName("department");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(4000)
                .HasColumnName("displayName");
            entity.Property(e => e.FacsimileTelephoneNumber)
                .HasMaxLength(4000)
                .HasColumnName("facsimileTelephoneNumber");
            entity.Property(e => e.Givenname)
                .HasMaxLength(4000)
                .HasColumnName("givenname");
            entity.Property(e => e.Mail)
                .HasMaxLength(4000)
                .HasColumnName("mail");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(4000)
                .HasColumnName("middleName");
            entity.Property(e => e.Mobile)
                .HasMaxLength(4000)
                .HasColumnName("mobile");
            entity.Property(e => e.Pager)
                .HasMaxLength(4000)
                .HasColumnName("pager");
            entity.Property(e => e.PhysicalDeliveryOfficeName)
                .HasMaxLength(4000)
                .HasColumnName("physicalDeliveryOfficeName");
            entity.Property(e => e.SAmaccountName)
                .HasMaxLength(4000)
                .HasColumnName("sAMAccountName");
            entity.Property(e => e.Sn)
                .HasMaxLength(4000)
                .HasColumnName("sn");
            entity.Property(e => e.Streetaddress)
                .HasMaxLength(4000)
                .HasColumnName("streetaddress");
            entity.Property(e => e.TelephoneNumber)
                .HasMaxLength(4000)
                .HasColumnName("telephoneNumber");
            entity.Property(e => e.Title)
                .HasMaxLength(4000)
                .HasColumnName("title");
        });

        modelBuilder.Entity<ViewAllPoDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_PO_Detail");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ItemCode).HasMaxLength(200);
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PurchaseOrdersDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.PurchaseOrdersTotal).HasColumnType("money");
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<ViewAvailableYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AvailableYear");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
        });

        modelBuilder.Entity<ViewBillPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BillPayments");

            entity.Property(e => e.AccountName).HasColumnName("Account_Name");
            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillId).HasColumnName("BillID");
            entity.Property(e => e.BillTotal).HasColumnType("money");
            entity.Property(e => e.DateReceived).HasColumnName("Date_Received");
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
        });

        modelBuilder.Entity<ViewBillRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BillRegister");

            entity.Property(e => e.BillDate).HasColumnType("datetime");
            entity.Property(e => e.BillId).HasColumnName("BillID");
            entity.Property(e => e.BillSubTotal).HasColumnType("money");
            entity.Property(e => e.BillTotal).HasColumnType("money");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
        });

        modelBuilder.Entity<ViewBudget>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Budget");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ViewBudgetbyCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BudgetbyCompany");

            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.BudgetId).HasColumnName("BudgetID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ViewCurrentMonthReceipt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CurrentMonthReceipts");

            entity.Property(e => e.AccountName).HasColumnName("Account_Name");
            entity.Property(e => e.Total).HasColumnType("money");
        });

        modelBuilder.Entity<ViewCurrentMonthSale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CurrentMonthSales");

            entity.Property(e => e.TotalSales).HasColumnType("money");
        });

        modelBuilder.Entity<ViewDuplicateInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_DuplicateInvoices");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.ExternalInvoiceNo)
                .HasMaxLength(50)
                .HasColumnName("ExternalInvoiceNO");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceTotal).HasColumnType("money");
        });

        modelBuilder.Entity<ViewGetOpenPurchaseOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_GetOpenPurchaseOrder");

            entity.Property(e => e.ListValue).HasMaxLength(50);
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.PurchaseOrdersDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.PurchaseOrdersTotal).HasColumnType("money");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewGetTapeGoogleSheet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_GetTapeGoogleSheet");

            entity.Property(e => e.ExternalInvoiceNo)
                .HasMaxLength(50)
                .HasColumnName("ExternalInvoiceNO");
            entity.Property(e => e.GrossProfit).HasColumnType("money");
            entity.Property(e => e.InvCoId).HasColumnName("InvCoID");
            entity.Property(e => e.InvDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InvEmpId).HasColumnName("InvEmpID");
            entity.Property(e => e.InvQty).HasColumnType("money");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceTotal).HasColumnType("money");
            entity.Property(e => e.ItemCode).HasMaxLength(200);
            entity.Property(e => e.Logistics).HasMaxLength(40);
            entity.Property(e => e.PaymentTerm).HasMaxLength(50);
            entity.Property(e => e.PocoId).HasColumnName("POCoID");
            entity.Property(e => e.PoempId).HasColumnName("POEmpID");
            entity.Property(e => e.Poqty)
                .HasColumnType("money")
                .HasColumnName("POQty");
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.Profit).HasColumnType("money");
            entity.Property(e => e.PurchaseDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.PurchaseOrdersTotal).HasColumnType("money");
            entity.Property(e => e.PurchasePrice).HasColumnType("money");
            entity.Property(e => e.SellingPrice).HasColumnType("money");
            entity.Property(e => e.TrackingInfo).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewIndividualProfitShare>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_IndividualProfitShare");

            entity.Property(e => e.InvDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.MyShare).HasColumnType("money");
        });

        modelBuilder.Entity<ViewInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Inventory");

            entity.Property(e => e.InvoiceRemainingQuantity).HasColumnType("money");
            entity.Property(e => e.ItemCode).HasMaxLength(200);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PurchaseOrdersDate).HasColumnType("datetime");
            entity.Property(e => e.TotalValue).HasColumnType("money");
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<ViewInvoiceRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_InvoiceRegister");

            entity.Property(e => e.ExternalInvoiceNo)
                .HasMaxLength(50)
                .HasColumnName("ExternalInvoiceNO");
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceSubTotal).HasColumnType("money");
            entity.Property(e => e.InvoiceTotal).HasColumnType("money");
        });

        modelBuilder.Entity<ViewInvoiceSalesId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_InvoiceSalesID");

            entity.Property(e => e.SaleInvoiceIdId).HasColumnName("Sale_InvoiceIdID");
        });

        modelBuilder.Entity<ViewInvoiceWeeklyTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_InvoiceWeeklyTotal");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.InvTotal).HasColumnType("money");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceId)
                .ValueGeneratedOnAdd()
                .HasColumnName("InvoiceID");
        });

        modelBuilder.Entity<ViewInvoicesReceipt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_InvoicesReceipts");

            entity.Property(e => e.AccountName).HasColumnName("Account_Name");
            entity.Property(e => e.DateReceived).HasColumnName("Date_Received");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceTotal).HasColumnType("money");
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");
        });

        modelBuilder.Entity<ViewIssueStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_IssueStatus");

            entity.Property(e => e.ListValue).HasMaxLength(50);
            entity.Property(e => e.Ticket).HasColumnName("ticket");
        });

        modelBuilder.Entity<ViewIssuesAssignedToStatusCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_IssuesAssignedToStatusCount");

            entity.Property(e => e.ListValue).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewIssuesDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_IssuesDetail");

            entity.Property(e => e.IssueId).HasColumnName("IssueID");
            entity.Property(e => e.OpenDate).HasColumnType("datetime");
            entity.Property(e => e.Priority).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TicketUrl)
                .HasMaxLength(58)
                .HasColumnName("TicketURL");
        });

        modelBuilder.Entity<ViewIssuesOpenedBy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_IssuesOpenedBy");

            entity.Property(e => e.ListValue).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewNatusFirewallDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_NatusFirewallDetails");

            entity.Property(e => e.Expr1)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewOpenInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_OpenInvoices");

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
        });

        modelBuilder.Entity<ViewOpenInvoiceSuggestedPo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_OpenInvoiceSuggestedPO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.InvoiceRemainingQuantity).HasColumnType("money");
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
        });

        modelBuilder.Entity<ViewOpenSalesOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_OpenSalesOrder");

            entity.Property(e => e.QuoteId).HasColumnName("QuoteID");
        });

        modelBuilder.Entity<ViewOpenTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_OpenTransactions");

            entity.Property(e => e.AccountName).HasColumnName("Account_Name");
        });

        modelBuilder.Entity<ViewPLdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_P&LDetails");

            entity.Property(e => e.AccountName).HasColumnName("Account_Name");
            entity.Property(e => e.Debit).HasColumnName("debit");
            entity.Property(e => e.OriginalDescription).HasColumnName("Original_Description");
        });

        modelBuilder.Entity<ViewPaymentAndTransactionsMatchOnAmount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PaymentAndTransactionsMatchOnAmount");

            entity.Property(e => e.AccountName).HasColumnName("Account_Name");
            entity.Property(e => e.DateReceived).HasColumnName("Date_Received");
            entity.Property(e => e.OriginalDescription).HasColumnName("Original_Description");
            entity.Property(e => e.Paymentside)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("paymentside");
        });

        modelBuilder.Entity<ViewPoInvTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PO_INV_Tracking");

            entity.Property(e => e.InvCoId).HasColumnName("InvCoID");
            entity.Property(e => e.InvDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InvEmpId).HasColumnName("InvEmpID");
            entity.Property(e => e.InvQty).HasColumnType("money");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ItemCode).HasMaxLength(200);
            entity.Property(e => e.PocoId).HasColumnName("POCoID");
            entity.Property(e => e.PoempId).HasColumnName("POEmpID");
            entity.Property(e => e.Poqty)
                .HasColumnType("money")
                .HasColumnName("POQty");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Profit).HasColumnType("money");
            entity.Property(e => e.PurchaseDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.PurchasePrice).HasColumnType("money");
            entity.Property(e => e.SellingPrice).HasColumnType("money");
        });

        modelBuilder.Entity<ViewPoandInvoicesNotMatched>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_POandInvoicesNotMatched");

            entity.Property(e => e.Blank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.PoPrice).HasColumnType("money");
            entity.Property(e => e.PoProductIe).HasColumnName("PoProductIE");
            entity.Property(e => e.Pocomment).HasColumnName("POComment");
            entity.Property(e => e.Poqty).HasColumnName("POQty");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<ViewPoregister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PORegister");

            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.PurchaseOrdersDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.PurchaseOrdersSubTotal).HasColumnType("money");
            entity.Property(e => e.PurchaseOrdersTotal).HasColumnType("money");
        });

        modelBuilder.Entity<ViewPortal2DashboardInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Portal2DashboardInvoices");

            entity.Property(e => e.Status)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasMaxLength(4000);
        });

        modelBuilder.Entity<ViewPototalbyVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_POTotalbyVendors");

            entity.Property(e => e.PoTotal)
                .HasColumnType("money")
                .HasColumnName("Po Total");
        });

        modelBuilder.Entity<ViewPowithNoBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_POwithNoBills");

            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.PurchaseOrdersDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.PurchaseOrdersTotal).HasColumnType("money");
        });

        modelBuilder.Entity<ViewProfitAndLoss>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProfitAndLoss");

            entity.Property(e => e.AccountName).HasColumnName("Account_Name");
            entity.Property(e => e.OriginalDescription).HasColumnName("Original_Description");
            entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");
        });

        modelBuilder.Entity<ViewProfitCompanyWise>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Profit CompanyWise");

            entity.Property(e => e.CustomerName).HasColumnName("Customer Name");
            entity.Property(e => e.InvCoId).HasColumnName("InvCoID");
            entity.Property(e => e.InvDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InvEmpId).HasColumnName("InvEmpID");
            entity.Property(e => e.InvQty).HasColumnType("money");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.ItemCode).HasMaxLength(200);
            entity.Property(e => e.PocoId).HasColumnName("POCoID");
            entity.Property(e => e.PoempId).HasColumnName("POEmpID");
            entity.Property(e => e.Poqty)
                .HasColumnType("money")
                .HasColumnName("POQty");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Profit).HasColumnType("money");
            entity.Property(e => e.PurchaseDate)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.PurchasePrice).HasColumnType("money");
            entity.Property(e => e.SellingPrice).HasColumnType("money");
        });

        modelBuilder.Entity<ViewPurchaseOrderWeeklyTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PurchaseOrderWeeklyTotal");

            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.Pototal)
                .HasColumnType("money")
                .HasColumnName("POTotal");
            entity.Property(e => e.PurchaseOrdersDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrdersId)
                .ValueGeneratedOnAdd()
                .HasColumnName("PurchaseOrdersID");
        });

        modelBuilder.Entity<ViewPurchasesbyCoAndVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PurchasesbyCoAndVendor");

            entity.Property(e => e.Frieght).HasColumnType("money");
            entity.Property(e => e.SubTotal).HasColumnType("money");
            entity.Property(e => e.Total).HasColumnType("money");
        });

        modelBuilder.Entity<ViewQuarterlySale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_QuarterlySales");

            entity.Property(e => e.Q1).HasColumnType("money");
            entity.Property(e => e.Q2).HasColumnType("money");
            entity.Property(e => e.Q3).HasColumnType("money");
            entity.Property(e => e.Q4).HasColumnType("money");
        });

        modelBuilder.Entity<ViewReceiptDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReceiptDetails");

            entity.Property(e => e.AccountNameId).HasColumnName("AccountNameID");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.DateReceived).HasColumnName("Date_Received");
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.PaymentTerm).HasMaxLength(50);
            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");
        });

        modelBuilder.Entity<ViewReceiptsBeforeInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReceiptsBeforeInvoices");

            entity.Property(e => e.InvoiceDate).HasMaxLength(4000);
            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.PaymentTerm).HasMaxLength(50);
            entity.Property(e => e.ReceiptDate).HasMaxLength(4000);
            entity.Property(e => e.ReceiptId).HasColumnName("ReceiptID");
        });

        modelBuilder.Entity<ViewRepeatWord>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_RepeatWords");

            entity.Property(e => e.AccountName).HasColumnName("Account_Name");
        });

        modelBuilder.Entity<ViewSalesOrderRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SalesOrderRegister");

            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.Porefrence)
                .HasMaxLength(50)
                .HasColumnName("PORefrence");
            entity.Property(e => e.QuoteDate).HasColumnType("datetime");
            entity.Property(e => e.QuoteId).HasColumnName("QuoteID");
            entity.Property(e => e.QuoteTotal).HasColumnType("money");
            entity.Property(e => e.SubTotal).HasColumnType("money");
        });

        modelBuilder.Entity<ViewSystemsSqlbackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SystemsSQLBackup");

            entity.Property(e => e.BackupFinishDate)
                .HasColumnType("datetime")
                .HasColumnName("backup_finish_date");
            entity.Property(e => e.BackupStartDate)
                .HasColumnType("datetime")
                .HasColumnName("backup_start_date");
            entity.Property(e => e.BackupType)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("backup_type");
            entity.Property(e => e.DatabaseName)
                .HasMaxLength(128)
                .HasColumnName("database_name");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PhysicalDeviceName)
                .HasMaxLength(260)
                .HasColumnName("physical_device_name");
            entity.Property(e => e.Server)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SizeInGb)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SizeInGB");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<ViewUploadToTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UploadToTransactions");

            entity.Property(e => e.AccountId).HasColumnName("Account_Id");
            entity.Property(e => e.AccountType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.AddedBy)
                .HasMaxLength(128)
                .HasColumnName("Added_by");
            entity.Property(e => e.AddedDate)
                .HasColumnType("datetime")
                .HasColumnName("Added_Date");
            entity.Property(e => e.Amount).HasMaxLength(50);
            entity.Property(e => e.Category)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DefaultActUser).HasColumnName("Default_ACT_User");
            entity.Property(e => e.Labels)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.OriginalDescription).HasColumnName("Original_Description");
            entity.Property(e => e.OriginalDescription1).HasColumnName("OriginalDescription");
            entity.Property(e => e.Personal)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SubCategory)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.TransactionType).HasColumnName("Transaction_Type");
        });

        modelBuilder.Entity<ViewUsersAndRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UsersAndRoles");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
