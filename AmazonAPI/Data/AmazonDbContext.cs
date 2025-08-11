using System;
using System.Collections.Generic;
using AmazonAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AmazonAPI.Data;

public partial class AmazonDbContext : DbContext
{
    public AmazonDbContext()
    {
    }

    public AmazonDbContext(DbContextOptions<AmazonDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Accounting> Accountings { get; set; }

    public virtual DbSet<Activelisting> Activelistings { get; set; }

    public virtual DbSet<AmazonAllPnL> AmazonAllPnLs { get; set; }

    public virtual DbSet<AmazonApiInsertLog> AmazonApiInsertLogs { get; set; }

    public virtual DbSet<AmazonApiProductInsertLog> AmazonApiProductInsertLogs { get; set; }

    public virtual DbSet<AmazonFakeTracking> AmazonFakeTrackings { get; set; }

    public virtual DbSet<AmazonOrderReport> AmazonOrderReports { get; set; }

    public virtual DbSet<ApiCreateAfter> ApiCreateAfters { get; set; }

    public virtual DbSet<CanceledOrderNotification> CanceledOrderNotifications { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<ChartofAcctToCategory> ChartofAcctToCategories { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<TempItd> TempItds { get; set; }

    public virtual DbSet<TempSynnexOrderStatusResponse> TempSynnexOrderStatusResponses { get; set; }

    public virtual DbSet<ViewMissingOrderItemList> ViewMissingOrderItemLists { get; set; }

    // Add this DbSet property
    public virtual DbSet<AmazonNotShippedModel> AmazonNotShippedModels { get; set; }

    public virtual DbSet<AmazonOrdersStats> AmazonOrdersStats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-HPH0FS4\\SQLEXPRESS;Database=AmazonApi;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Accounting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Accounting");

            entity.Property(e => e.AccountType)
                .HasMaxLength(50)
                .HasColumnName("account_type");
            entity.Property(e => e.DateTime)
                .HasMaxLength(50)
                .HasColumnName("date_time");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .HasColumnName("description");
            entity.Property(e => e.FbaFees).HasColumnName("fba_fees");
            entity.Property(e => e.Fulfillment)
                .HasMaxLength(50)
                .HasColumnName("fulfillment");
            entity.Property(e => e.Marketplace)
                .HasMaxLength(50)
                .HasColumnName("marketplace");
            entity.Property(e => e.MarketplaceWithheldTax).HasColumnName("marketplace_withheld_tax");
            entity.Property(e => e.OrderCity)
                .HasMaxLength(50)
                .HasColumnName("order_city");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("order_id");
            entity.Property(e => e.OrderPostal)
                .HasMaxLength(50)
                .HasColumnName("order_postal");
            entity.Property(e => e.OrderState)
                .HasMaxLength(50)
                .HasColumnName("order_state");
            entity.Property(e => e.Other).HasColumnName("other");
            entity.Property(e => e.OtherTransactionFees).HasColumnName("other_transaction_fees");
            entity.Property(e => e.ProductSales).HasColumnName("product_sales");
            entity.Property(e => e.ProductSalesTax).HasColumnName("product_sales_tax");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.SellingFees).HasColumnName("selling_fees");
            entity.Property(e => e.SettlementId).HasColumnName("settlement_id");
            entity.Property(e => e.ShippingCredits).HasColumnName("shipping_credits");
            entity.Property(e => e.ShippingCreditsTax).HasColumnName("shipping_credits_tax");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("sku");
            entity.Property(e => e.TaxCollectionModel)
                .HasMaxLength(50)
                .HasColumnName("tax_collection_model");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<Activelisting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Activelisting");

            entity.Property(e => e.AddDelete)
                .HasMaxLength(1)
                .HasColumnName("add_delete");
            entity.Property(e => e.Asin1)
                .HasMaxLength(50)
                .HasColumnName("asin1");
            entity.Property(e => e.Asin2)
                .HasMaxLength(1)
                .HasColumnName("asin2");
            entity.Property(e => e.Asin3)
                .HasMaxLength(1)
                .HasColumnName("asin3");
            entity.Property(e => e.BidForFeaturedPlacement)
                .HasMaxLength(1)
                .HasColumnName("bid_for_featured_placement");
            entity.Property(e => e.BusinessPrice).HasColumnName("Business_Price");
            entity.Property(e => e.ExpeditedShipping)
                .HasMaxLength(1)
                .HasColumnName("expedited_shipping");
            entity.Property(e => e.FulfillmentChannel)
                .HasMaxLength(50)
                .HasColumnName("fulfillment_channel");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(1)
                .HasColumnName("image_url");
            entity.Property(e => e.ItemCondition).HasColumnName("item_condition");
            entity.Property(e => e.ItemDescription).HasColumnName("item_description");
            entity.Property(e => e.ItemIsMarketplace)
                .HasMaxLength(50)
                .HasColumnName("item_is_marketplace");
            entity.Property(e => e.ItemName).HasColumnName("item_name");
            entity.Property(e => e.ItemNote)
                .HasMaxLength(1)
                .HasColumnName("item_note");
            entity.Property(e => e.ListingId)
                .HasMaxLength(50)
                .HasColumnName("listing_id");
            entity.Property(e => e.MerchantShippingGroup)
                .HasMaxLength(50)
                .HasColumnName("merchant_shipping_group");
            entity.Property(e => e.OpenDate)
                .HasMaxLength(50)
                .HasColumnName("open_date");
            entity.Property(e => e.PendingQuantity).HasColumnName("pending_quantity");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductId)
                .HasMaxLength(50)
                .HasColumnName("product_id");
            entity.Property(e => e.ProductIdType).HasColumnName("product_id_type");
            entity.Property(e => e.ProgressiveLowerBound1)
                .HasMaxLength(1)
                .HasColumnName("Progressive_Lower_Bound_1");
            entity.Property(e => e.ProgressiveLowerBound2)
                .HasMaxLength(1)
                .HasColumnName("Progressive_Lower_Bound_2");
            entity.Property(e => e.ProgressiveLowerBound3)
                .HasMaxLength(1)
                .HasColumnName("Progressive_Lower_Bound_3");
            entity.Property(e => e.ProgressivePrice1)
                .HasMaxLength(1)
                .HasColumnName("Progressive_Price_1");
            entity.Property(e => e.ProgressivePrice2)
                .HasMaxLength(1)
                .HasColumnName("Progressive_Price_2");
            entity.Property(e => e.ProgressivePrice3)
                .HasMaxLength(1)
                .HasColumnName("Progressive_Price_3");
            entity.Property(e => e.ProgressivePriceType)
                .HasMaxLength(1)
                .HasColumnName("Progressive_Price_Type");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.QuantityLowerBound1).HasColumnName("Quantity_Lower_Bound_1");
            entity.Property(e => e.QuantityLowerBound2).HasColumnName("Quantity_Lower_Bound_2");
            entity.Property(e => e.QuantityLowerBound3).HasColumnName("Quantity_Lower_Bound_3");
            entity.Property(e => e.QuantityLowerBound4).HasColumnName("Quantity_Lower_Bound_4");
            entity.Property(e => e.QuantityLowerBound5).HasColumnName("Quantity_Lower_Bound_5");
            entity.Property(e => e.QuantityPrice1).HasColumnName("Quantity_Price_1");
            entity.Property(e => e.QuantityPrice2).HasColumnName("Quantity_Price_2");
            entity.Property(e => e.QuantityPrice3).HasColumnName("Quantity_Price_3");
            entity.Property(e => e.QuantityPrice4).HasColumnName("Quantity_Price_4");
            entity.Property(e => e.QuantityPrice5).HasColumnName("Quantity_Price_5");
            entity.Property(e => e.QuantityPriceType)
                .HasMaxLength(50)
                .HasColumnName("Quantity_Price_Type");
            entity.Property(e => e.SellerSku)
                .HasMaxLength(50)
                .HasColumnName("seller_sku");
            entity.Property(e => e.WillShipInternationally)
                .HasMaxLength(1)
                .HasColumnName("will_ship_internationally");
            entity.Property(e => e.ZshopBoldface)
                .HasMaxLength(1)
                .HasColumnName("zshop_boldface");
            entity.Property(e => e.ZshopBrowsePath)
                .HasMaxLength(1)
                .HasColumnName("zshop_browse_path");
            entity.Property(e => e.ZshopCategory1)
                .HasMaxLength(1)
                .HasColumnName("zshop_category1");
            entity.Property(e => e.ZshopShippingFee)
                .HasMaxLength(1)
                .HasColumnName("zshop_shipping_fee");
            entity.Property(e => e.ZshopStorefrontFeature)
                .HasMaxLength(1)
                .HasColumnName("zshop_storefront_feature");
        });

        modelBuilder.Entity<AmazonAllPnL>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AmazonAllPnL");

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.ItemTaxAmount).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.LatestShipDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderSource).HasMaxLength(20);
            entity.Property(e => e.PostalCode).HasMaxLength(20);
            entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            entity.Property(e => e.PurchaseOrderStatus).HasMaxLength(50);
            entity.Property(e => e.PurchaseOrdersId).HasColumnName("PurchaseOrdersID");
            entity.Property(e => e.PurchaseTotal).HasColumnType("money");
            entity.Property(e => e.SellingPrice).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.SellingStatus).HasMaxLength(50);
            entity.Property(e => e.SellingTotal).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.ShipMethod).HasMaxLength(100);
            entity.Property(e => e.ShippingProgram).HasMaxLength(100);
            entity.Property(e => e.Sku)
                .HasMaxLength(100)
                .HasColumnName("SKU");
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.TrackingId)
                .HasMaxLength(50)
                .HasColumnName("TrackingID");
            entity.Property(e => e.TrackingStatus).HasMaxLength(50);
            entity.Property(e => e.VendorShipDate).HasColumnType("datetime");
            entity.Property(e => e.VendorShipVia).HasMaxLength(50);
        });

        modelBuilder.Entity<AmazonApiInsertLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AmazonApiInsertLog");

            entity.Property(e => e.AmazonOrderid).HasMaxLength(50);
            entity.Property(e => e.ContactCompanyId).HasColumnName("ContactCompanyID");
            entity.Property(e => e.ContactId).HasColumnName("ContactID");
            entity.Property(e => e.ExecDate).HasColumnType("datetime");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PurchaseOrderDetailId).HasColumnName("PurchaseOrderDetailID");
            entity.Property(e => e.PurchaseOrderId).HasColumnName("PurchaseOrderID");
        });

        modelBuilder.Entity<AmazonApiProductInsertLog>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AmazonOrderid).HasMaxLength(100);
            entity.Property(e => e.ExecDate).HasColumnType("datetime");
            entity.Property(e => e.SellerSku)
                .HasMaxLength(50)
                .HasColumnName("SellerSKU");
        });

        modelBuilder.Entity<AmazonFakeTracking>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmazonOrderId)
                .HasMaxLength(150)
                .HasColumnName("AmazonOrderID");
            entity.Property(e => e.FakeTrackingId)
                .HasMaxLength(150)
                .HasColumnName("FakeTrackingID");
            entity.Property(e => e.RealTracking).HasMaxLength(150);
        });

        modelBuilder.Entity<AmazonOrderReport>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__AmazonOr__6298D2AD968B3301");

            entity.ToTable("AmazonOrderReport");

            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .HasColumnName("order-id");
            entity.Property(e => e.AlreadyPaid).HasColumnName("already-paid");
            entity.Property(e => e.BuyerCompanyName)
                .HasMaxLength(128)
                .HasColumnName("buyer-company-name");
            entity.Property(e => e.BuyerEmail)
                .HasMaxLength(256)
                .HasColumnName("buyer-email");
            entity.Property(e => e.BuyerName)
                .HasMaxLength(128)
                .HasColumnName("buyer-name");
            entity.Property(e => e.BuyerPhoneNumber)
                .HasMaxLength(64)
                .HasColumnName("buyer-phone-number");
            entity.Property(e => e.CodCollectibleAmount).HasColumnName("cod-collectible-amount");
            entity.Property(e => e.Cpf)
                .HasMaxLength(64)
                .HasColumnName("cpf");
            entity.Property(e => e.Currency)
                .HasMaxLength(8)
                .HasColumnName("currency");
            entity.Property(e => e.DeliveryEndDate)
                .HasMaxLength(64)
                .HasColumnName("delivery-end-date");
            entity.Property(e => e.DeliveryInstructions)
                .HasMaxLength(256)
                .HasColumnName("delivery-Instructions");
            entity.Property(e => e.DeliveryStartDate)
                .HasMaxLength(64)
                .HasColumnName("delivery-start-date");
            entity.Property(e => e.DeliveryTimeZone)
                .HasMaxLength(64)
                .HasColumnName("delivery-time-zone");
            entity.Property(e => e.EarliestDeliveryDate)
                .HasMaxLength(64)
                .HasColumnName("earliest-delivery-date");
            entity.Property(e => e.EarliestShipDate)
                .HasMaxLength(64)
                .HasColumnName("earliest-ship-date");
            entity.Property(e => e.IsBusinessOrder)
                .HasMaxLength(10)
                .HasColumnName("is-business-order");
            entity.Property(e => e.ItemPrice).HasColumnName("item-price");
            entity.Property(e => e.ItemTax).HasColumnName("item-tax");
            entity.Property(e => e.LatestDeliveryDate)
                .HasMaxLength(64)
                .HasColumnName("latest-delivery-date");
            entity.Property(e => e.LatestShipDate)
                .HasMaxLength(64)
                .HasColumnName("latest-ship-date");
            entity.Property(e => e.NumberOfItems).HasColumnName("number-of-items");
            entity.Property(e => e.OrderItemId)
                .HasMaxLength(50)
                .HasColumnName("order-item-id");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(32)
                .HasColumnName("payment-method");
            entity.Property(e => e.PaymentMethodFee).HasColumnName("payment-method-fee");
            entity.Property(e => e.PaymentsDate)
                .HasColumnType("datetime")
                .HasColumnName("payments-date");
            entity.Property(e => e.PriceDesignation)
                .HasMaxLength(64)
                .HasColumnName("price-designation");
            entity.Property(e => e.ProductName)
                .HasMaxLength(512)
                .HasColumnName("product-name");
            entity.Property(e => e.PurchaseDate)
                .HasColumnType("datetime")
                .HasColumnName("purchase-date");
            entity.Property(e => e.PurchaseOrderNumber)
                .HasMaxLength(64)
                .HasColumnName("purchase-order-number");
            entity.Property(e => e.QuantityPurchased).HasColumnName("quantity-purchased");
            entity.Property(e => e.RecipientName)
                .HasMaxLength(128)
                .HasColumnName("recipient-name");
            entity.Property(e => e.ShipAddress1)
                .HasMaxLength(256)
                .HasColumnName("ship-address-1");
            entity.Property(e => e.ShipAddress2)
                .HasMaxLength(256)
                .HasColumnName("ship-address-2");
            entity.Property(e => e.ShipAddress3)
                .HasMaxLength(256)
                .HasColumnName("ship-address-3");
            entity.Property(e => e.ShipCity)
                .HasMaxLength(128)
                .HasColumnName("ship-city");
            entity.Property(e => e.ShipCountry)
                .HasMaxLength(8)
                .HasColumnName("ship-country");
            entity.Property(e => e.ShipPhoneNumber)
                .HasMaxLength(64)
                .HasColumnName("ship-phone-number");
            entity.Property(e => e.ShipPostalCode)
                .HasMaxLength(32)
                .HasColumnName("ship-postal-code");
            entity.Property(e => e.ShipServiceLevel)
                .HasMaxLength(128)
                .HasColumnName("ship-service-level");
            entity.Property(e => e.ShipState)
                .HasMaxLength(64)
                .HasColumnName("ship-state");
            entity.Property(e => e.ShippingPrice).HasColumnName("shipping-price");
            entity.Property(e => e.ShippingTax).HasColumnName("shipping-tax");
            entity.Property(e => e.SignatureConfirmationRecommended)
                .HasMaxLength(16)
                .HasColumnName("signature-confirmation-recommended");
            entity.Property(e => e.Sku)
                .HasMaxLength(128)
                .HasColumnName("sku");
            entity.Property(e => e.TaxCollectionModel)
                .HasMaxLength(64)
                .HasColumnName("tax-collection-model");
            entity.Property(e => e.TaxCollectionResponsibleParty)
                .HasMaxLength(64)
                .HasColumnName("tax-collection-responsible-party");
        });

        modelBuilder.Entity<ApiCreateAfter>(entity =>
        {
            entity.ToTable("APiCreateAfter");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateAfter).HasMaxLength(50);
        });

        modelBuilder.Entity<CanceledOrderNotification>(entity =>
        {
            entity.HasKey(e => e.AmazonOrderId).HasName("PK__Canceled__3997F8F286AB2454");

            entity.Property(e => e.AmazonOrderId).HasMaxLength(32);
            entity.Property(e => e.NotifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Categori__19093A2BDE1E563C");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");

            entity.HasOne(d => d.ParentCategory).WithMany(p => p.InverseParentCategory)
                .HasForeignKey(d => d.ParentCategoryId)
                .HasConstraintName("fk_parent_category");
        });

        modelBuilder.Entity<ChartofAcctToCategory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompId).HasColumnName("Comp_ID");
            entity.Property(e => e.GlCode)
                .HasMaxLength(13)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("GL_Code");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.IsIspu).HasColumnName("IsISPU");
            entity.Property(e => e.IsSoldByAb).HasColumnName("IsSoldByAB");
            entity.Property(e => e.OrderTotalAmount).HasColumnType("numeric(7, 2)");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemIdlocal);

            entity.Property(e => e.OrderItemIdlocal).HasColumnName("OrderItemIDLocal");
            entity.Property(e => e.Asin).HasColumnName("ASIN");
            entity.Property(e => e.SellerSku).HasColumnName("SellerSKU");
        });

        modelBuilder.Entity<TempItd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempITD");

            entity.Property(e => e.AmazonOrderId).HasColumnName("AmazonOrderID");
            entity.Property(e => e.Amount)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<TempSynnexOrderStatusResponse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempSynnexOrderStatusResponse");

            entity.Property(e => e.Code).HasMaxLength(20);
            entity.Property(e => e.CustomerNumber).HasMaxLength(20);
            entity.Property(e => e.OrderResponseId)
                .ValueGeneratedOnAdd()
                .HasColumnName("OrderResponseID");
            entity.Property(e => e.Podatetime)
                .HasColumnType("datetime")
                .HasColumnName("PODatetime");
            entity.Property(e => e.Ponumber)
                .HasMaxLength(20)
                .HasColumnName("PONumber");
            entity.Property(e => e.ResponseDateTime).HasColumnType("datetime");
            entity.Property(e => e.ResponseElapsedTime).HasMaxLength(10);
        });

        modelBuilder.Entity<ViewMissingOrderItemList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MissingOrderItemList");

            entity.Property(e => e.OrderId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AmazonNotShippedModel>(entity =>
        {
            entity.HasNoKey(); // Mark as keyless
            entity.ToView(null); // Not mapped to a table
        });

        modelBuilder.Entity<AmazonOrdersStats>(entity =>
        {
            entity.HasNoKey(); // Mark as keyless since it's from a stored procedure
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
