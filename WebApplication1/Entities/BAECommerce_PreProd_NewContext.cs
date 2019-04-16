using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class BAECommerce_PreProd_NewContext : DbContext
    {
        public BAECommerce_PreProd_NewContext()
        {
        }

        public BAECommerce_PreProd_NewContext(DbContextOptions<BAECommerce_PreProd_NewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressHeader> AddressHeader { get; set; }
        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<AgreementTemplate> AgreementTemplate { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<CampaignSeo> CampaignSeo { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryCategory> CategoryCategory { get; set; }
        public virtual DbSet<CategoryCategoryNew> CategoryCategoryNew { get; set; }
        public virtual DbSet<CategoryNew> CategoryNew { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<County> County { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<EmailTemplateType> EmailTemplateType { get; set; }
        public virtual DbSet<EntityType> EntityType { get; set; }
        public virtual DbSet<ExcelImportedProduct> ExcelImportedProduct { get; set; }
        public virtual DbSet<File> File { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<IntegrationLog> IntegrationLog { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<MasterProduct> MasterProduct { get; set; }
        public virtual DbSet<MasterProductHistory> MasterProductHistory { get; set; }
        public virtual DbSet<MasterProductNew> MasterProductNew { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuOld> MenuOld { get; set; }
        public virtual DbSet<MikroIntegration> MikroIntegration { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderActivity> OrderActivity { get; set; }
        public virtual DbSet<OrderActivityType> OrderActivityType { get; set; }
        public virtual DbSet<OrderCancelRequest> OrderCancelRequest { get; set; }
        public virtual DbSet<OrderCancelRequestReason> OrderCancelRequestReason { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<OrderItemReturnRequest> OrderItemReturnRequest { get; set; }
        public virtual DbSet<OrderItemReturnRequestReason> OrderItemReturnRequestReason { get; set; }
        public virtual DbSet<PageLog> PageLog { get; set; }
        public virtual DbSet<PaymentLog> PaymentLog { get; set; }
        public virtual DbSet<PersonelInformation> PersonelInformation { get; set; }
        public virtual DbSet<PriceList> PriceList { get; set; }
        public virtual DbSet<PriceRoundingList> PriceRoundingList { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttribute { get; set; }
        public virtual DbSet<ProductAttributeGroup> ProductAttributeGroup { get; set; }
        public virtual DbSet<ProductAttributeNew> ProductAttributeNew { get; set; }
        public virtual DbSet<ProductAttributeSelection> ProductAttributeSelection { get; set; }
        public virtual DbSet<ProductAttributeSelectionNew> ProductAttributeSelectionNew { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValue { get; set; }
        public virtual DbSet<ProductAttributeValueNew> ProductAttributeValueNew { get; set; }
        public virtual DbSet<ProductComment> ProductComment { get; set; }
        public virtual DbSet<ProductDiscount> ProductDiscount { get; set; }
        public virtual DbSet<ProductExcel> ProductExcel { get; set; }
        public virtual DbSet<ProductFile> ProductFile { get; set; }
        public virtual DbSet<ProductGroup> ProductGroup { get; set; }
        public virtual DbSet<ProductHistory> ProductHistory { get; set; }
        public virtual DbSet<ProductNew> ProductNew { get; set; }
        public virtual DbSet<ProductOption> ProductOption { get; set; }
        public virtual DbSet<ProductOptionValue> ProductOptionValue { get; set; }
        public virtual DbSet<ProductTag> ProductTag { get; set; }
        public virtual DbSet<ProductTemplate> ProductTemplate { get; set; }
        public virtual DbSet<ProductTemplateNew> ProductTemplateNew { get; set; }
        public virtual DbSet<ProductTemplateProductAttribute> ProductTemplateProductAttribute { get; set; }
        public virtual DbSet<ProductTemplateProductAttributeNew> ProductTemplateProductAttributeNew { get; set; }
        public virtual DbSet<RelatedProduct> RelatedProduct { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<ShippingCompany> ShippingCompany { get; set; }
        public virtual DbSet<ShippingCompanyPrice> ShippingCompanyPrice { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<Showcase> Showcase { get; set; }
        public virtual DbSet<SiteSetting> SiteSetting { get; set; }
        public virtual DbSet<Slider> Slider { get; set; }
        public virtual DbSet<SliderFile> SliderFile { get; set; }
        public virtual DbSet<SlugInfo> SlugInfo { get; set; }
        public virtual DbSet<SportsTeam> SportsTeam { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierBrand> SupplierBrand { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Tax> Tax { get; set; }
        public virtual DbSet<UnitType> UnitType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Vat> Vat { get; set; }
        public virtual DbSet<Widget> Widget { get; set; }
        public virtual DbSet<WidgetFile> WidgetFile { get; set; }

        // Unable to generate entity type for table 'dbo.MasterProduct_060920181918'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ÜrünResimleri'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SablonOzellik'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.urunler_eski'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Urunler'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Supplier2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OzellikDeger'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EksikUrunResimleri'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tumUrunler'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.YuvarlanmisFiyat'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SonUrunler'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Kategori'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.indirimler'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.200.0.52;Database=BA.ECommerce_PreProd_New;user id=ecommerce_user;password=Password1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressContent)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.AddressHeaderId).HasColumnName("AddressHeaderID");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CountyId).HasColumnName("CountyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.CustomerSurname).HasMaxLength(200);

                entity.Property(e => e.FullTextAddress).IsRequired();

                entity.Property(e => e.MasterAddressId).HasColumnName("MasterAddressID");

                entity.Property(e => e.MikroId).HasColumnName("MikroID");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonelInformationId).HasColumnName("PersonelInformationID");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PostCode).HasMaxLength(20);

                entity.Property(e => e.TaxNumber).HasMaxLength(10);

                entity.Property(e => e.TaxOffice).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.AddressHeader)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.AddressHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_AddressHeader");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_City");

                entity.HasOne(d => d.County)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_County");
            });

            modelBuilder.Entity<AddressHeader>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<AddressHeader>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddressHeader_AddressHeader");
            });

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => new { e.Value, e.Key })
                    .HasName("UX_HangFire_CounterAggregated_Key")
                    .IsUnique();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AgreementTemplate>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Template).IsRequired();
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name_Unique_20180703-142011")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.LogoPath).IsUnicode(false);

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.WebSiteUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasIndex(e => new { e.StartDate, e.EndDate })
                    .HasName("NonClusteredIndex-20181016-180451");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AmountOfAppliedDiscount).HasColumnType("money");

                entity.Property(e => e.AmountOfDiscount).HasColumnType("money");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .IsUnicode(false);

                entity.Property(e => e.MaximumAmount).HasColumnType("money");

                entity.Property(e => e.MinimumAmount).HasColumnType("money");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PercentageOfDiscount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('javascript:void(0)')");
            });

            modelBuilder.Entity<CampaignSeo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeoDescription)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.SeoKeywords)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.SeoTitle)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("NonClusteredIndex-20180412-132354")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.MinumumInstallmentPrice).HasColumnType("money");

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.ProductTemplate)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.ProductTemplateId)
                    .HasConstraintName("FK_Category_ProductTemplate");
            });

            modelBuilder.Entity<CategoryCategory>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("NonClusteredIndex-20180906-193339");

                entity.HasIndex(e => e.MasterCategoryId)
                    .HasName("NonClusteredIndex-20180906-193354");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MasterCategoryId).HasColumnName("MasterCategoryID");

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryCategoryCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryCategory_CategoryId");

                entity.HasOne(d => d.MasterCategory)
                    .WithMany(p => p.CategoryCategoryMasterCategory)
                    .HasForeignKey(d => d.MasterCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryCategory_MasterCategoryId");
            });

            modelBuilder.Entity<CategoryCategoryNew>(entity =>
            {
                entity.ToTable("CategoryCategory_new");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MasterCategoryId).HasColumnName("MasterCategoryID");

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoryNew>(entity =>
            {
                entity.ToTable("Category_new");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAdusername)
                    .IsRequired()
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .IsRequired()
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => new { e.Value, e.Key })
                    .HasName("IX_HangFire_Counter_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<County>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAdusername)
                    .IsRequired()
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .IsRequired()
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.County)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_County_City1");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Bcc)
                    .HasColumnName("BCC")
                    .HasMaxLength(4000);

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(4000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.EnableSsl).HasColumnName("EnableSSL");

                entity.Property(e => e.MailAddress).HasMaxLength(255);

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.Server)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.ToTable("EMailTemplate");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Template).IsRequired();
            });

            modelBuilder.Entity<EmailTemplateType>(entity =>
            {
                entity.ToTable("EMailTemplateType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntityType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.RedirectAction)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RedirectController)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingAction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingController)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExcelImportedProduct>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ExcelImportedProduct)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExcelImportedProduct_File");

                entity.HasOne(d => d.MasterProduct)
                    .WithMany(p => p.ExcelImportedProduct)
                    .HasForeignKey(d => d.MasterProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExcelImportedProduct_MasterProduct");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => new { e.ExpireAt, e.Key })
                    .HasName("IX_HangFire_Hash_Key");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Hash_ExpireAt");

                entity.HasIndex(e => new { e.Key, e.Field })
                    .HasName("UX_HangFire_Hash_Key_Field")
                    .IsUnique();

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AspectRatio)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IntegrationLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Job)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.MasterId).HasColumnName("MasterID");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.ToTable("JobParameter", "HangFire");

                entity.HasIndex(e => new { e.JobId, e.Name })
                    .HasName("IX_HangFire_JobParameter_JobIdAndName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.ToTable("JobQueue", "HangFire");

                entity.HasIndex(e => new { e.Queue, e.FetchedAt })
                    .HasName("IX_HangFire_JobQueue_QueueAndFetchedAt");

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_List_ExpireAt");

                entity.HasIndex(e => new { e.ExpireAt, e.Value, e.Key })
                    .HasName("IX_HangFire_List_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value).HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<MasterProduct>(entity =>
            {
                entity.HasIndex(e => e.BrandId)
                    .HasName("NonClusteredIndex-20180906-202613");

                entity.HasIndex(e => e.StockCode)
                    .HasName("NonClusteredIndex-20190122-103225")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.BoxDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxHeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CriticalStock).HasDefaultValueSql("((2147483647))");

                entity.Property(e => e.Depth).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.FakePrice).HasColumnType("money");

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogisticType).HasMaxLength(50);

                entity.Property(e => e.MainPrice).HasColumnType("money");

                entity.Property(e => e.MinumumInstallmentPrice).HasColumnType("money");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.PackageDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageHeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesPrice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.SeoDescription).HasMaxLength(500);

                entity.Property(e => e.SeoKeywords).HasMaxLength(500);

                entity.Property(e => e.SeoTitle).HasMaxLength(500);

                entity.Property(e => e.ShortDescription).HasMaxLength(4000);

                entity.Property(e => e.Stage).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");

                entity.Property(e => e.VatId).HasColumnName("VatID");

                entity.Property(e => e.Weight).HasDefaultValueSql("((0))");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkflowMessage)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.MasterProduct)
                    .HasForeignKey(d => d.BrandId)
                    .HasConstraintName("FK_Product_Brand");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MasterProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Product_Category");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.MasterProduct)
                    .HasForeignKey(d => d.SectorId)
                    .HasConstraintName("FK_Product_Sector");

                entity.HasOne(d => d.SlugInfo)
                    .WithMany(p => p.MasterProduct)
                    .HasForeignKey(d => d.SlugInfoId)
                    .HasConstraintName("FK_MasterProduct_SlugInfo");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.MasterProduct)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_MasterProduct_Supplier");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.MasterProduct)
                    .HasForeignKey(d => d.TaxId)
                    .HasConstraintName("FK_MasterProduct_Tax");

                entity.HasOne(d => d.UnitType)
                    .WithMany(p => p.MasterProduct)
                    .HasForeignKey(d => d.UnitTypeId)
                    .HasConstraintName("FK_Product_UnitType");

                entity.HasOne(d => d.Vat)
                    .WithMany(p => p.MasterProduct)
                    .HasForeignKey(d => d.VatId)
                    .HasConstraintName("FK_Product_VAT");
            });

            modelBuilder.Entity<MasterProductHistory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BoxDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxHeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Depth).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogisticType).HasMaxLength(50);

                entity.Property(e => e.MainPrice).HasColumnType("money");

                entity.Property(e => e.MasterId).HasColumnName("MasterID");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.PackageDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageHeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.SeoDescription).HasMaxLength(500);

                entity.Property(e => e.SeoKeywords).HasMaxLength(500);

                entity.Property(e => e.SeoTitle).HasMaxLength(500);

                entity.Property(e => e.ShortDescription).HasMaxLength(4000);

                entity.Property(e => e.Stage).HasDefaultValueSql("((0))");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");

                entity.Property(e => e.VatId).HasColumnName("VatID");

                entity.Property(e => e.Weight).HasDefaultValueSql("((0))");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkflowMessage)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<MasterProductNew>(entity =>
            {
                entity.ToTable("MasterProduct_new");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BoxDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxHeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.BoxWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Depth).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Height).HasDefaultValueSql("((0))");

                entity.Property(e => e.LogisticType).HasMaxLength(50);

                entity.Property(e => e.MainPrice).HasColumnType("money");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(300);

                entity.Property(e => e.PackageDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageHeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageWeight).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.SeoDescription).HasMaxLength(500);

                entity.Property(e => e.SeoKeywords).HasMaxLength(500);

                entity.Property(e => e.SeoTitle).HasMaxLength(500);

                entity.Property(e => e.ShortDescription).HasMaxLength(4000);

                entity.Property(e => e.Stage).HasDefaultValueSql("((0))");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");

                entity.Property(e => e.VatId).HasColumnName("VatID");

                entity.Property(e => e.Weight).HasDefaultValueSql("((0))");

                entity.Property(e => e.Width).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkflowMessage)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.SlugInfo)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.SlugInfoId)
                    .HasConstraintName("FK_Menu2_SlugInfo");
            });

            modelBuilder.Entity<MenuOld>(entity =>
            {
                entity.ToTable("Menu_old");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Menu_Menu");

                entity.HasOne(d => d.SlugInfo)
                    .WithMany(p => p.MenuOld)
                    .HasForeignKey(d => d.SlugInfoId)
                    .HasConstraintName("FK_Menu_SlugInfo");
            });

            modelBuilder.Entity<MikroIntegration>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Avenue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddressID");

                entity.Property(e => e.BillingAvenue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BillingCity)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BillingCounty)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.BillingStreet)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CompanyName).HasMaxLength(400);

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentCode).HasMaxLength(30);

                entity.Property(e => e.Email).HasMaxLength(127);

                entity.Property(e => e.Kdvamount).HasColumnName("KDVAmount");

                entity.Property(e => e.MikroAddressId).HasColumnName("MikroAddressID");

                entity.Property(e => e.MikroBillingAddressId).HasColumnName("MikroBillingAddressID");

                entity.Property(e => e.MikroOrderItemId).HasColumnName("MikroOrderItemID");

                entity.Property(e => e.MikroUserId).HasColumnName("MikroUserID");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StockCode)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaxNumber).HasMaxLength(10);

                entity.Property(e => e.TaxOffice).HasMaxLength(50);

                entity.Property(e => e.UserFullName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BillingAddress).HasMaxLength(255);

                entity.Property(e => e.BillingAddressContent).HasMaxLength(255);

                entity.Property(e => e.BillingCityName).HasMaxLength(50);

                entity.Property(e => e.BillingCompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingCountyName).HasMaxLength(50);

                entity.Property(e => e.BillingFirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingLastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingTaxNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BillingTaxOffice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignName).HasMaxLength(200);

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CouponDiscountAmount).HasColumnType("money");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.MaskedCardNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PaidPrice).HasColumnType("money");

                entity.Property(e => e.PaymentCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentLink).IsUnicode(false);

                entity.Property(e => e.PaymentPrice).HasColumnType("money");

                entity.Property(e => e.PaymentShippingPrice).HasColumnType("money");

                entity.Property(e => e.PersonalInformationCurrentCode).HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress).HasMaxLength(255);

                entity.Property(e => e.ShippingAddressContent).HasMaxLength(255);

                entity.Property(e => e.ShippingCampaignName).HasMaxLength(250);

                entity.Property(e => e.ShippingCityName).HasMaxLength(50);

                entity.Property(e => e.ShippingCompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountyName).HasMaxLength(50);

                entity.Property(e => e.ShippingFirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingLastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPrice).HasColumnType("money");

                entity.Property(e => e.ShippingTaxNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTaxOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TotalDiscountAmount).HasColumnType("money");

                entity.Property(e => e.TotalDiscountPercentage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.TotalProductDiscountAmount).HasColumnType("money");

                entity.Property(e => e.TotalProductDiscountPercentage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TotalProductPrice).HasColumnType("money");

                entity.Property(e => e.TotalSalesPrice).HasColumnType("money");

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATAmount")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<OrderActivity>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderActivityType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OrderCancelRequest>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderCancelRequestReason>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CargoNumber).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("money");

                entity.Property(e => e.DiscountAmountPercentage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.MikroId).HasColumnName("MikroID");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPrice).HasColumnType("money");

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.ShippingCode).HasMaxLength(100);

                entity.Property(e => e.ShippingLink).HasMaxLength(255);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.StockCode).HasMaxLength(25);

                entity.Property(e => e.TotalDiscountAmount).HasColumnType("money");

                entity.Property(e => e.TotalDiscountAmountPercentage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.TotalProductPrice).HasColumnType("money");

                entity.Property(e => e.TotalSalesPrice).HasColumnType("money");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Vatid).HasColumnName("VATId");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItem_Order");
            });

            modelBuilder.Entity<OrderItemReturnRequest>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderItemReturnRequestReason>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PageLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Query)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Slug)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentLog>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasMaxLength(8);

                entity.Property(e => e.PaidPrice).HasColumnType("money");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonelInformation>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentCode).HasMaxLength(30);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Interests).HasMaxLength(4000);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MasterId).HasColumnName("MasterID");

                entity.Property(e => e.MikroId).HasColumnName("MikroID");

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.SportsTeamId).HasColumnName("SportsTeamID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.SportsTeam)
                    .WithMany(p => p.PersonelInformation)
                    .HasForeignKey(d => d.SportsTeamId)
                    .HasConstraintName("FK_PersonelInformation_SportsTeam");
            });

            modelBuilder.Entity<PriceList>(entity =>
            {
                entity.HasIndex(e => e.MasterProductId)
                    .HasName("NonClusteredIndex-20180906-190641");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CampaignEndDate).HasColumnType("datetime");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignStartDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ListPrice).HasColumnType("money");

                entity.Property(e => e.MasterProductId).HasColumnName("MasterProductID");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPrice).HasColumnType("money");

                entity.Property(e => e.SalesVatAmount).HasColumnType("money");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.VatAmount).HasColumnType("money");
            });

            modelBuilder.Entity<PriceRoundingList>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MaximumSalesPrice).HasColumnType("money");

                entity.Property(e => e.MinimumSalesPrice).HasColumnType("money");

                entity.Property(e => e.ModifiedAdusername)
                    .IsRequired()
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .IsRequired()
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoundedPrice).HasColumnType("money");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.AutoId)
                    .HasName("IX_Product_AutoId")
                    .IsUnique();

                entity.HasIndex(e => e.MasterProductId)
                    .HasName("NonClusteredIndex-20180906-192522");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoxBarcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MainPrice).HasColumnType("money");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PackageBarcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.MasterProduct)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.MasterProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_MasterProduct");
            });

            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ProductAttribute)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_ProductAttribute_ProductAttributeGroup");
            });

            modelBuilder.Entity<ProductAttributeGroup>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ProductAttributeNew>(entity =>
            {
                entity.ToTable("ProductAttribute_new");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ProductAttributeSelection>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.ProductAttributeSelection)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAttributeSelection_ProductAttribute");
            });

            modelBuilder.Entity<ProductAttributeSelectionNew>(entity =>
            {
                entity.ToTable("ProductAttributeSelection_new");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProductAttributeValue>(entity =>
            {
                entity.HasIndex(e => new { e.ProductId, e.ProductAttributeId, e.ProductAttributeSelectionId, e.Status })
                    .HasName("NonClusteredIndex-20180829-112834");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAttributeId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProductAttributeSelectionId).HasDefaultValueSql("('4EAC8773-14A4-44D5-B440-021E7DF5D54D')");

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductAttributeValue)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAttributeValue_ProductAttribute");

                entity.HasOne(d => d.ProductAttributeSelection)
                    .WithMany(p => p.ProductAttributeValue)
                    .HasForeignKey(d => d.ProductAttributeSelectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAttributeValue_ProductAttributeSelection");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAttributeValue)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductAttributeValue_Product");
            });

            modelBuilder.Entity<ProductAttributeValueNew>(entity =>
            {
                entity.ToTable("ProductAttributeValue_new");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductComment>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.MasterProduct)
                    .WithMany(p => p.ProductComment)
                    .HasForeignKey(d => d.MasterProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductComment_MasterProduct");
            });

            modelBuilder.Entity<ProductDiscount>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MasterProduct)
                    .WithMany(p => p.ProductDiscount)
                    .HasForeignKey(d => d.MasterProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductDiscount_MasterProduct");
            });

            modelBuilder.Entity<ProductExcel>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AkcayKodu).HasMaxLength(1000);

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BarkodAdet).HasMaxLength(1000);

                entity.Property(e => e.BarkodKoli).HasMaxLength(1000);

                entity.Property(e => e.BarkodKutu).HasMaxLength(1000);

                entity.Property(e => e.Birim1Adet).HasMaxLength(1000);

                entity.Property(e => e.Birim1Agirlik).HasMaxLength(1000);

                entity.Property(e => e.Birim1Boy).HasMaxLength(1000);

                entity.Property(e => e.Birim1Derinlik).HasMaxLength(1000);

                entity.Property(e => e.Birim1En).HasMaxLength(1000);

                entity.Property(e => e.Birim2Agirlik).HasMaxLength(1000);

                entity.Property(e => e.Birim2Boy).HasMaxLength(1000);

                entity.Property(e => e.Birim2Carpani).HasMaxLength(1000);

                entity.Property(e => e.Birim2Derinlik).HasMaxLength(1000);

                entity.Property(e => e.Birim2En).HasMaxLength(1000);

                entity.Property(e => e.Birim2Kutu).HasMaxLength(1000);

                entity.Property(e => e.Birim3Agirlik).HasMaxLength(1000);

                entity.Property(e => e.Birim3Boy).HasMaxLength(1000);

                entity.Property(e => e.Birim3Carpani).HasMaxLength(1000);

                entity.Property(e => e.Birim3Derinlik).HasMaxLength(1000);

                entity.Property(e => e.Birim3En).HasMaxLength(1000);

                entity.Property(e => e.Birim3Koli).HasMaxLength(1000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FotografUrl).HasMaxLength(1000);

                entity.Property(e => e.IlgiliIlgisiz).HasMaxLength(1000);

                entity.Property(e => e.Iskonto1).HasMaxLength(1000);

                entity.Property(e => e.Iskonto2).HasMaxLength(1000);

                entity.Property(e => e.Iskonto3).HasMaxLength(1000);

                entity.Property(e => e.Iskonto4).HasMaxLength(1000);

                entity.Property(e => e.Iskonto5).HasMaxLength(1000);

                entity.Property(e => e.Kategori).HasMaxLength(1000);

                entity.Property(e => e.Kdv).HasMaxLength(1000);

                entity.Property(e => e.ListeFiyati).HasMaxLength(1000);

                entity.Property(e => e.LojistikTipi).HasMaxLength(1000);

                entity.Property(e => e.Marka).HasMaxLength(1000);

                entity.Property(e => e.MarkaLogoUrl).HasMaxLength(1000);

                entity.Property(e => e.MinumumSiparisAdedi).HasMaxLength(1000);

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParakendeSatisFiyati).HasMaxLength(1000);

                entity.Property(e => e.StokKodu).HasMaxLength(1000);

                entity.Property(e => e.TedarikciKodu).HasMaxLength(1000);

                entity.Property(e => e.TeslimSuresi).HasMaxLength(1000);

                entity.Property(e => e.UrunAciklamasi).HasMaxLength(1000);

                entity.Property(e => e.UrunAdi).HasMaxLength(1000);

                entity.Property(e => e.UrunKisaAciklamasi).HasMaxLength(1000);

                entity.Property(e => e.UrunOzellikleri).HasMaxLength(1000);

                entity.Property(e => e.VideoUrl).HasMaxLength(1000);

                entity.Property(e => e.YeniKod).HasMaxLength(1000);
            });

            modelBuilder.Entity<ProductFile>(entity =>
            {
                entity.HasIndex(e => e.FileId)
                    .HasName("NonClusteredIndex-20180906-202407");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Order).HasDefaultValueSql("((2))");

                entity.Property(e => e.StockCode).HasMaxLength(50);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ProductFile)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductFile_File");

                entity.HasOne(d => d.MasterProduct)
                    .WithMany(p => p.ProductFile)
                    .HasForeignKey(d => d.MasterProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductFile_Product");
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.HasIndex(e => e.MasterProductId)
                    .HasName("NonClusteredIndex-20181016-181148");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ProductGroup)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductGroup_Group");

                entity.HasOne(d => d.MasterProduct)
                    .WithMany(p => p.ProductGroup)
                    .HasForeignKey(d => d.MasterProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductGroup_MasterProduct");
            });

            modelBuilder.Entity<ProductHistory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoxBarcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MainPrice).HasColumnType("money");

                entity.Property(e => e.MasterId).HasColumnName("MasterID");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PackageBarcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductNew>(entity =>
            {
                entity.ToTable("Product_new");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BoxBarcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MainPrice).HasColumnType("money");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PackageBarcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductOption>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ProductOptionValue>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductOptionId });

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOptionValue)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOptionValue_Product");

                entity.HasOne(d => d.ProductOption)
                    .WithMany(p => p.ProductOptionValue)
                    .HasForeignKey(d => d.ProductOptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductOptionValue_ProductOption");
            });

            modelBuilder.Entity<ProductTag>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductTag)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTag_MasterProduct");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ProductTag)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTag_Tag");
            });

            modelBuilder.Entity<ProductTemplate>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ProductTemplateNew>(entity =>
            {
                entity.ToTable("ProductTemplate_new");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ProductTemplateProductAttribute>(entity =>
            {
                entity.HasKey(e => new { e.ProductTemplateId, e.ProductAttributeId });

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductTemplateProductAttribute)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTemplateProductAttribute_ProductAttribute");

                entity.HasOne(d => d.ProductTemplate)
                    .WithMany(p => p.ProductTemplateProductAttribute)
                    .HasForeignKey(d => d.ProductTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductTemplateProductAttribute_ProductTemplate");
            });

            modelBuilder.Entity<ProductTemplateProductAttributeNew>(entity =>
            {
                entity.HasKey(e => new { e.ProductTemplateId, e.ProductAttributeId });

                entity.ToTable("ProductTemplateProductAttribute_new");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RelatedProduct>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.RelatedProductId });

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.RelatedProductProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RelatedProduct_Product");

                entity.HasOne(d => d.RelatedProductNavigation)
                    .WithMany(p => p.RelatedProductRelatedProductNavigation)
                    .HasForeignKey(d => d.RelatedProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RelatedProduct_Product_Related");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version);

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId).HasColumnName("AutoID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Set_ExpireAt");

                entity.HasIndex(e => new { e.Key, e.Value })
                    .HasName("UX_HangFire_Set_KeyAndValue")
                    .IsUnique();

                entity.HasIndex(e => new { e.ExpireAt, e.Value, e.Key })
                    .HasName("IX_HangFire_Set_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<ShippingCompany>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<ShippingCompanyPrice>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<ShoppingCart>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CouponCampaignId).HasColumnName("CouponCampaignID");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CouponCodeMinimumAmount).HasColumnType("money");

                entity.Property(e => e.CouponDiscountAmount).HasColumnType("money");

                entity.Property(e => e.CouponDiscountPercent).HasColumnType("money");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.TotalPriceAfterCouponDiscount).HasColumnType("money");

                entity.HasOne(d => d.Session)
                    .WithMany(p => p.ShoppingCart)
                    .HasForeignKey(d => d.SessionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCart_Session");
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.MasterProduct)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.MasterProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartItem_MasterProduct");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ShoppingCartItem_Product");

                entity.HasOne(d => d.ShoppingCart)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.ShoppingCartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShoppingCartItem_ShoppingCart");
            });

            modelBuilder.Entity<Showcase>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SiteSetting>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FacebookUsername)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InstagramUsername)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MinimumAmountForInstallment).HasColumnType("money");

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeoDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SeoKeywords)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SeoTitle)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TwitterUsername)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SliderFile>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SliderId).HasColumnName("SliderID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.SliderFile)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SliderFile_File");
            });

            modelBuilder.Entity<SlugInfo>(entity =>
            {
                entity.HasIndex(e => new { e.EntityId, e.EntityTypeId, e.Status })
                    .HasName("NonClusteredIndex-20180906-193502");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Slug).HasMaxLength(500);

                entity.HasOne(d => d.EntityType)
                    .WithMany(p => p.SlugInfo)
                    .HasForeignKey(d => d.EntityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlugInfo_EntityType");

                entity.HasOne(d => d.RedirectSlugInfo)
                    .WithMany(p => p.InverseRedirectSlugInfo)
                    .HasForeignKey(d => d.RedirectSlugInfoId)
                    .HasConstraintName("FK_SlugInfo_SlugInfo");
            });

            modelBuilder.Entity<SportsTeam>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAdusername)
                    .HasColumnName("ModifiedADUsername")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State", "HangFire");

                entity.HasIndex(e => e.JobId)
                    .HasName("IX_HangFire_State_JobId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasIndex(e => e.MasterProductId)
                    .HasName("IX_Stock")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockCode).HasMaxLength(50);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.MasterProduct)
                    .WithOne(p => p.Stock)
                    .HasForeignKey<Stock>(d => d.MasterProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stock_MasterProduct");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SupplierBrand>(entity =>
            {
                entity.HasKey(e => new { e.SupplierId, e.BrandId });

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.SupplierBrand)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierBrand_Brand");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierBrand)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierBrand_Supplier");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name_Unique")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Tax>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAdUsername)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Value).HasColumnType("decimal(4, 2)");
            });

            modelBuilder.Entity<UnitType>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShortName).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.McUserId)
                    .HasName("IX_User")
                    .IsUnique();

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentCode).HasMaxLength(50);

                entity.Property(e => e.MikroId).HasColumnName("MikroID");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_User_Supplier");
            });

            modelBuilder.Entity<Vat>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Widget>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<WidgetFile>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AutoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.ModifiedAduserName)
                    .HasColumnName("ModifiedADUserName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedComputerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedIp)
                    .HasColumnName("ModifiedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.WidgetContent)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.WidgetHeader)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.WidgetId).HasColumnName("WidgetID");

                entity.Property(e => e.WidgetUrl)
                    .IsRequired()
                    .HasColumnName("WidgetURL")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Widget)
                    .WithMany(p => p.WidgetFile)
                    .HasForeignKey(d => d.WidgetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WidgetFile_Widget");
            });
        }
    }
}
