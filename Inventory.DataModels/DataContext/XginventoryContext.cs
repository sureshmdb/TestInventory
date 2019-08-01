using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Inventory.DataModels.DataContext
{
    public partial class XginventoryContext : DbContext
    {
        public XginventoryContext()
        {
        }

        public XginventoryContext(DbContextOptions<XginventoryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AutoBuildParameters> AutoBuildParameters { get; set; }
        public virtual DbSet<AverageBy> AverageBy { get; set; }
        public virtual DbSet<Batch> Batch { get; set; }
        public virtual DbSet<Channel> Channel { get; set; }
        public virtual DbSet<ChannelService> ChannelService { get; set; }
        public virtual DbSet<ChannelServiceMapping> ChannelServiceMapping { get; set; }
        public virtual DbSet<CollectionMethod> CollectionMethod { get; set; }
        public virtual DbSet<ComscoreSweepDates> ComscoreSweepDates { get; set; }
        public virtual DbSet<Daycode> Daycode { get; set; }
        public virtual DbSet<Daypart> Daypart { get; set; }
        public virtual DbSet<DaypartDefinition> DaypartDefinition { get; set; }
        public virtual DbSet<DaypartDefinitionNetwork> DaypartDefinitionNetwork { get; set; }
        public virtual DbSet<DaypartDemo> DaypartDemo { get; set; }
        public virtual DbSet<DaypartDeviation> DaypartDeviation { get; set; }
        public virtual DbSet<DaypartDeviationNetwork> DaypartDeviationNetwork { get; set; }
        public virtual DbSet<DaypartMarket> DaypartMarket { get; set; }
        public virtual DbSet<DaypartNetwork> DaypartNetwork { get; set; }
        public virtual DbSet<Demographic> Demographic { get; set; }
        public virtual DbSet<DemographicCategory> DemographicCategory { get; set; }
        public virtual DbSet<DemographicDaypart> DemographicDaypart { get; set; }
        public virtual DbSet<DistributionSource> DistributionSource { get; set; }
        public virtual DbSet<DominantOptions> DominantOptions { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<GenreInventoryRange> GenreInventoryRange { get; set; }
        public virtual DbSet<GenreMapping> GenreMapping { get; set; }
        public virtual DbSet<GenreNetworkMapping> GenreNetworkMapping { get; set; }
        public virtual DbSet<GenreSaleRange> GenreSaleRange { get; set; }
        public virtual DbSet<InventoryDataConfiguration> InventoryDataConfiguration { get; set; }
        public virtual DbSet<LengthFactorChannelMapping> LengthFactorChannelMapping { get; set; }
        public virtual DbSet<LengthFactorNetworkMapping> LengthFactorNetworkMapping { get; set; }
        public virtual DbSet<LocalLengthFactor> LocalLengthFactor { get; set; }
        public virtual DbSet<LocalLengthFactorDeviation> LocalLengthFactorDeviation { get; set; }
        public virtual DbSet<LocalLengthFactorSpots> LocalLengthFactorSpots { get; set; }
        public virtual DbSet<LocalLengthFactorSpotsDeviation> LocalLengthFactorSpotsDeviation { get; set; }
        public virtual DbSet<LocalSpotLength> LocalSpotLength { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<MarketChannelAffiliation> MarketChannelAffiliation { get; set; }
        public virtual DbSet<MarketService> MarketService { get; set; }
        public virtual DbSet<MarketServiceMapping> MarketServiceMapping { get; set; }
        public virtual DbSet<MonthlySurveyBooks> MonthlySurveyBooks { get; set; }
        public virtual DbSet<MonthlySurveyBooksMapping> MonthlySurveyBooksMapping { get; set; }
        public virtual DbSet<Network> Network { get; set; }
        public virtual DbSet<NetworkChannelAffiliation> NetworkChannelAffiliation { get; set; }
        public virtual DbSet<NetworkDaypartDemo> NetworkDaypartDemo { get; set; }
        public virtual DbSet<NetworkLengthFactor> NetworkLengthFactor { get; set; }
        public virtual DbSet<NetworkLengthFactorDeviation> NetworkLengthFactorDeviation { get; set; }
        public virtual DbSet<NetworkLengthFactorSpots> NetworkLengthFactorSpots { get; set; }
        public virtual DbSet<NetworkLengthFactorSpotsDeviation> NetworkLengthFactorSpotsDeviation { get; set; }
        public virtual DbSet<NetworkService> NetworkService { get; set; }
        public virtual DbSet<NetworkServiceMapping> NetworkServiceMapping { get; set; }
        public virtual DbSet<NetworkSpotLength> NetworkSpotLength { get; set; }
        public virtual DbSet<NielsenSweepDates> NielsenSweepDates { get; set; }
        public virtual DbSet<NonDominantOptions> NonDominantOptions { get; set; }
        public virtual DbSet<OrbitProgramLocal> OrbitProgramLocal { get; set; }
        public virtual DbSet<OrbitProgramNetwork> OrbitProgramNetwork { get; set; }
        public virtual DbSet<PavSearchParameters> PavSearchParameters { get; set; }
        public virtual DbSet<PlaybackType> PlaybackType { get; set; }
        public virtual DbSet<ProgramAudience> ProgramAudience { get; set; }
        public virtual DbSet<ProgramAudiencePav> ProgramAudiencePav { get; set; }
        public virtual DbSet<ProgramDaypartLocal> ProgramDaypartLocal { get; set; }
        public virtual DbSet<ProgramDaypartNetwork> ProgramDaypartNetwork { get; set; }
        public virtual DbSet<ProgramGenreLocal> ProgramGenreLocal { get; set; }
        public virtual DbSet<ProgramGenreNetwork> ProgramGenreNetwork { get; set; }
        public virtual DbSet<ProgramHiatusLocal> ProgramHiatusLocal { get; set; }
        public virtual DbSet<ProgramHiatusNetwork> ProgramHiatusNetwork { get; set; }
        public virtual DbSet<ProgramLocal> ProgramLocal { get; set; }
        public virtual DbSet<ProgramMatch> ProgramMatch { get; set; }
        public virtual DbSet<ProgramNetwork> ProgramNetwork { get; set; }
        public virtual DbSet<ProgramRate> ProgramRate { get; set; }
        public virtual DbSet<ProgramTagLocal> ProgramTagLocal { get; set; }
        public virtual DbSet<ProgramTagNetwork> ProgramTagNetwork { get; set; }
        public virtual DbSet<RangeDetails> RangeDetails { get; set; }
        public virtual DbSet<RateCardChannelMapping> RateCardChannelMapping { get; set; }
        public virtual DbSet<RateCardNetworkMapping> RateCardNetworkMapping { get; set; }
        public virtual DbSet<RateCardUsers> RateCardUsers { get; set; }
        public virtual DbSet<Ratecard> Ratecard { get; set; }
        public virtual DbSet<RatingSource> RatingSource { get; set; }
        public virtual DbSet<RoundFactor> RoundFactor { get; set; }
        public virtual DbSet<SectionChannelMapping> SectionChannelMapping { get; set; }
        public virtual DbSet<SectionLevel> SectionLevel { get; set; }
        public virtual DbSet<SectionNetworkMapping> SectionNetworkMapping { get; set; }
        public virtual DbSet<SpecialMarketMapping> SpecialMarketMapping { get; set; }
        public virtual DbSet<SpotLengthChannelMapping> SpotLengthChannelMapping { get; set; }
        public virtual DbSet<SpotLengthNetworkMapping> SpotLengthNetworkMapping { get; set; }
        public virtual DbSet<SubSampleIndicator> SubSampleIndicator { get; set; }
        public virtual DbSet<SurveySampleType> SurveySampleType { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<TagInventoryRange> TagInventoryRange { get; set; }
        public virtual DbSet<TagMapping> TagMapping { get; set; }
        public virtual DbSet<TagNetworkMapping> TagNetworkMapping { get; set; }
        public virtual DbSet<TagSaleRange> TagSaleRange { get; set; }
        public virtual DbSet<TbRatesBy> TbRatesBy { get; set; }
        public virtual DbSet<Tenant> Tenant { get; set; }
        public virtual DbSet<TenantChannel> TenantChannel { get; set; }
        public virtual DbSet<TenantMarket> TenantMarket { get; set; }
        public virtual DbSet<TenantNetwork> TenantNetwork { get; set; }
        public virtual DbSet<TssufileComment> TssufileComment { get; set; }
        public virtual DbSet<TssufileConfig> TssufileConfig { get; set; }
        public virtual DbSet<TssufileDemo> TssufileDemo { get; set; }
        public virtual DbSet<TssufileDemoTrack> TssufileDemoTrack { get; set; }
        public virtual DbSet<TssufileHeader> TssufileHeader { get; set; }
        public virtual DbSet<TssufileMaster> TssufileMaster { get; set; }
        public virtual DbSet<TssufileTrailer> TssufileTrailer { get; set; }
        public virtual DbSet<TssumasterDaypartMapping> TssumasterDaypartMapping { get; set; }
        public virtual DbSet<TssumasterDemoMapping> TssumasterDemoMapping { get; set; }
        public virtual DbSet<UserChannel> UserChannel { get; set; }
        public virtual DbSet<UserDetail> UserDetail { get; set; }
        public virtual DbSet<UserMarket> UserMarket { get; set; }
        public virtual DbSet<UserMarketGroup> UserMarketGroup { get; set; }
        public virtual DbSet<UserMarketGroupDetails> UserMarketGroupDetails { get; set; }
        public virtual DbSet<UserTenantChannel> UserTenantChannel { get; set; }
        public virtual DbSet<UserTenantMarket> UserTenantMarket { get; set; }
        public virtual DbSet<UserTenantNetwork> UserTenantNetwork { get; set; }
        public virtual DbSet<VideaAcknowledge> VideaAcknowledge { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<AutoBuildParameters>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_AutoBuildParameters_Id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("AutoBuildParameters", "inv");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RatingSourceId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.AverageBy)
                    .WithMany(p => p.AutoBuildParameters)
                    .HasForeignKey(d => d.AverageById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProgramMatch)
                    .WithMany(p => p.AutoBuildParameters)
                    .HasForeignKey(d => d.ProgramMatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AverageBy>(entity =>
            {
                entity.HasKey(e => e.AverageById)
                    .HasName("PK_AverageBy_AverageById")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("AverageBy", "inv");

                entity.Property(e => e.AverageBy1)
                    .IsRequired()
                    .HasColumnName("AverageBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Batch>(entity =>
            {
                entity.ToTable("Batch", "inv");

                entity.Property(e => e.BatchName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastPostDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.HasKey(e => e.MdmchannelId)
                    .HasName("PK_mdmChannel");

                entity.ToTable("Channel", "mdm");

                entity.Property(e => e.MdmchannelId)
                    .HasColumnName("MDMChannelId")
                    .ValueGeneratedNever();

                entity.Property(e => e.AudienceEstimatesIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BroadcastChannel)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CallLetterChangeDate).HasColumnType("date");

                entity.Property(e => e.ChannelSourceId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ChannelTotalsIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.ExpiredDate).HasColumnType("date");

                entity.Property(e => e.MdmChannelLegacyCallLetters)
                    .HasColumnName("MDM_ChannelLegacyCallLetters")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MdmchannelCallLetters)
                    .HasColumnName("MDMChannelCallLetters")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.MdmchannelLongName)
                    .HasColumnName("MDMChannelLongName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ParentPlusIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramNamesIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReportabilityStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SatelliteIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChannelService>(entity =>
            {
                entity.ToTable("ChannelService", "service");

                entity.HasIndex(e => e.ChannelName)
                    .HasName("UK_ChannelService_ChannelName")
                    .IsUnique();

                entity.Property(e => e.ChannelName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChannelServiceMapping>(entity =>
            {
                entity.ToTable("ChannelServiceMapping", "service");

                entity.HasOne(d => d.ChannelService)
                    .WithMany(p => p.ChannelServiceMapping)
                    .HasForeignKey(d => d.ChannelServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CollectionMethod>(entity =>
            {
                entity.ToTable("CollectionMethod", "mdm");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComscoreSweepDates>(entity =>
            {
                entity.ToTable("ComscoreSweepDates", "mdm");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.SweepName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Daycode>(entity =>
            {
                entity.HasKey(e => e.DaysId)
                    .HasName("PK_Daycode_1");

                entity.ToTable("Daycode", "inv");

                entity.Property(e => e.DaysId).ValueGeneratedNever();

                entity.Property(e => e.DayCode1)
                    .IsRequired()
                    .HasColumnName("DayCode")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Daypart>(entity =>
            {
                entity.HasKey(e => e.DaypartId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Daypart", "inv");

                entity.HasIndex(e => e.DaypartName)
                    .HasName("UQ__Daypart__2C9F3F5099258EEF")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DaypartCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DaypartDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DaypartName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DaypartDefinition>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("DaypartDefinition", "inv");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DayPartDefinitionName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.DaypartMarket)
                    .WithMany(p => p.DaypartDefinition)
                    .HasForeignKey(d => d.DaypartMarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DaypartDe__Daypa__4E1E9780");
            });

            modelBuilder.Entity<DaypartDefinitionNetwork>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("DaypartDefinitionNetwork", "inv");

                entity.HasIndex(e => new { e.DaypartNetworkId, e.DaysId })
                    .HasName("UK_DaypartDefinitionNetwork")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DayPartDefinitionName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DaypartDemo>(entity =>
            {
                entity.ToTable("DaypartDemo", "inv");

                entity.HasIndex(e => new { e.MarketId, e.DaypartId, e.DemoId, e.RatingSourceId, e.UserId })
                    .HasName("UK_DaypartDemo_MarketId_DaypartId_DemoId_RatingSourceId_UserId")
                    .IsUnique();

                entity.HasOne(d => d.Daypart)
                    .WithMany(p => p.DaypartDemo)
                    .HasForeignKey(d => d.DaypartId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DaypartDeviation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("DaypartDeviation", "inv");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DayPartDeviationName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.DaypartMarket)
                    .WithMany(p => p.DaypartDeviation)
                    .HasForeignKey(d => d.DaypartMarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DaypartDe__Daypa__5006DFF2");
            });

            modelBuilder.Entity<DaypartDeviationNetwork>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("DaypartDeviationNetwork", "inv");

                entity.HasIndex(e => new { e.DaypartNetworkId, e.DaysId, e.MdmnetworkId })
                    .HasName("UK_DaypartDeviationNetwork")
                    .IsUnique();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DayPartDeviationName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MdmnetworkId).HasColumnName("MDMNetworkId");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DaypartMarket>(entity =>
            {
                entity.HasKey(e => e.DaypartMarketId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("DaypartMarket", "inv");

                entity.HasIndex(e => new { e.MarketId, e.DaypartId })
                    .HasName("IX_DaypartMarket")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Daypart)
                    .WithMany(p => p.DaypartMarket)
                    .HasForeignKey(d => d.DaypartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DaypartMa__Daypa__50FB042B");
            });

            modelBuilder.Entity<DaypartNetwork>(entity =>
            {
                entity.HasKey(e => e.DaypartNetworkId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("DaypartNetwork", "inv");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MdmnetworkId).HasColumnName("MDMNetworkId");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Demographic>(entity =>
            {
                entity.ToTable("Demographic", "mdm");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AltSourceName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DemographicCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("DemographicCategory", "mdm");

                entity.HasIndex(e => e.CategoryName)
                    .HasName("UQ_DemograhicCategory_Name")
                    .IsUnique();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DemographicDaypart>(entity =>
            {
                entity.HasKey(e => e.DemographicId)
                    .HasName("PK_Demographic_Daypart_DemographicId");

                entity.ToTable("Demographic_Daypart", "mdm");

                entity.HasIndex(e => new { e.RatingSourceId, e.Name })
                    .HasName("UQ_Demographic_Daypart_RatingSourceId_Name")
                    .IsUnique();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DistributionSource>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("Pk_DistributionSource_Id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("DistributionSource", "mdm");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AltSourceName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DominantOptions>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_DominantOptions_Id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("DominantOptions", "inv");

                entity.Property(e => e.Assign)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GenreId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Genre", "inv");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GenreDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GenreInventoryRange>(entity =>
            {
                entity.ToTable("GenreInventoryRange", "inv");

                entity.HasIndex(e => new { e.GenreId, e.DaypartId })
                    .HasName("UQ_GenreInventoryRange")
                    .IsUnique();

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.GenreInventoryRange)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GenreInve__Genre__51EF2864");
            });

            modelBuilder.Entity<GenreMapping>(entity =>
            {
                entity.ToTable("GenreMapping", "inv");

                entity.HasIndex(e => new { e.GenreId, e.MarketId, e.MdmchannelId })
                    .HasName("UQ_GenreMapping")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.GenreMapping)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GenreMapp__Genre__52E34C9D");
            });

            modelBuilder.Entity<GenreNetworkMapping>(entity =>
            {
                entity.ToTable("GenreNetworkMapping", "inv");

                entity.HasIndex(e => new { e.GenreId, e.MdmnetworkId, e.MarketId, e.MdmchannelId })
                    .HasName("UQ_GenreNetworkMapping")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.Property(e => e.MdmnetworkId).HasColumnName("MDMNetworkId");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.GenreNetworkMapping)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GenreNetw__Genre__53D770D6");
            });

            modelBuilder.Entity<GenreSaleRange>(entity =>
            {
                entity.ToTable("GenreSaleRange", "inv");

                entity.HasIndex(e => e.GenreId)
                    .HasName("UQ_GenreSaleRange")
                    .IsUnique();

                entity.HasOne(d => d.Genre)
                    .WithOne(p => p.GenreSaleRange)
                    .HasForeignKey<GenreSaleRange>(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GenreSale__Genre__54CB950F");
            });

            modelBuilder.Entity<InventoryDataConfiguration>(entity =>
            {
                entity.ToTable("InventoryDataConfiguration", "inv");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientSecret)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataConsumerName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GrantType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Scope)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceEndpoint)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TokenEndpoint)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LengthFactorChannelMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LengthFactorChannelMapping", "pricing");

                entity.HasIndex(e => new { e.LengthFactorId, e.MarketId, e.MdmchannelId })
                    .HasName("Uk_LengthFactorChannelMapping")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.Property(e => e.RoundTo).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.LengthFactor)
                    .WithMany(p => p.LengthFactorChannelMapping)
                    .HasForeignKey(d => d.LengthFactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LengthFactorChannelMappingwithSpotLength");
            });

            modelBuilder.Entity<LengthFactorNetworkMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LengthFactorNetworkMapping", "pricing");

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.Property(e => e.MdmnetworkId).HasColumnName("MDMNetworkId");

                entity.Property(e => e.RoundTo).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.LengthFactor)
                    .WithMany(p => p.LengthFactorNetworkMapping)
                    .HasForeignKey(d => d.LengthFactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LengthFactorNetworkMappingithLengthFactor");
            });

            modelBuilder.Entity<LocalLengthFactor>(entity =>
            {
                entity.HasKey(e => e.LengthFactorId)
                    .HasName("PK_LengthFactor")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LocalLengthFactor", "pricing");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCustom).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LengthFactorDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LocalLengthFactorDeviation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LocalLengthFactorDeviation", "pricing");

                entity.Property(e => e.RoundTo).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.LengthFactor)
                    .WithMany(p => p.LocalLengthFactorDeviation)
                    .HasForeignKey(d => d.LengthFactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LocalLengthFactorSpots>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_LengthFactorSpots")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LocalLengthFactorSpots", "pricing");

                entity.Property(e => e.LengthFactor)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LengthFactorNavigation)
                    .WithMany(p => p.LocalLengthFactorSpots)
                    .HasForeignKey(d => d.LengthFactorId);
            });

            modelBuilder.Entity<LocalLengthFactorSpotsDeviation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LocalLengthFactorSpotsDeviation", "pricing");

                entity.Property(e => e.LengthFactor).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.LengthFactorNavigation)
                    .WithMany(p => p.LocalLengthFactorSpotsDeviation)
                    .HasForeignKey(d => d.LengthFactorId);
            });

            modelBuilder.Entity<LocalSpotLength>(entity =>
            {
                entity.HasKey(e => e.SpotLengthId)
                    .HasName("PK_SpotLength")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("LocalSpotLength", "pricing");

                entity.HasIndex(e => e.SpotLength)
                    .HasName("UQ__LocalSpo__8DE96302740933DB")
                    .IsUnique();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsCustom)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LengthFactor).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.HasKey(e => e.MdmmarketId)
                    .HasName("PK_mdmMarket")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Market", "mdm");

                entity.Property(e => e.MdmmarketId)
                    .HasColumnName("MDMMarketId")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Dmacode).HasColumnName("DMACode");

                entity.Property(e => e.GeographyName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.GeorgaphyIndicator)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Isdummy).HasColumnName("isdummy");

                entity.Property(e => e.MarketAbbrev)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MarketLegacyName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MarketName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MarketType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MeasurementType)
                    .HasColumnName("Measurement_Type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OvnDayStart).HasColumnName("OVN_Day_Start");

                entity.Property(e => e.PlayBackTypeId)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvince)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketChannelAffiliation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_MarketChannelAffiliation_Id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("MarketChannelAffiliation", "mdm");

                entity.HasIndex(e => new { e.MarketSourceId, e.MdmchannelId })
                    .HasName("UK_MarketChannelAffiliation_MarketSourceId_MDMChannelId")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");
            });

            modelBuilder.Entity<MarketService>(entity =>
            {
                entity.ToTable("MarketService", "service");

                entity.HasIndex(e => e.MarketName)
                    .HasName("UK_MarketService_MarketName")
                    .IsUnique();

                entity.Property(e => e.MarketName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketServiceMapping>(entity =>
            {
                entity.ToTable("MarketServiceMapping", "service");

                entity.HasOne(d => d.MarketService)
                    .WithMany(p => p.MarketServiceMapping)
                    .HasForeignKey(d => d.MarketServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MonthlySurveyBooks>(entity =>
            {
                entity.HasKey(e => e.SurveyId)
                    .HasName("PK_MonthlySurveyBooks_SurveyId");

                entity.ToTable("MonthlySurveyBooks", "mdm");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SurveyBookName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MonthlySurveyBooksMapping>(entity =>
            {
                entity.ToTable("MonthlySurveyBooksMapping", "mdm");

                entity.Property(e => e.CollectionMethod)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MdmmarketId).HasColumnName("MDMMarketId");

                entity.Property(e => e.PlaybackType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubSampleIndicator)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SurveySampleType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.MonthlySurveyBooksMapping)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Network>(entity =>
            {
                entity.HasKey(e => e.MdmnetworkId);

                entity.ToTable("Network", "mdm");

                entity.Property(e => e.MdmnetworkId)
                    .HasColumnName("MDMNetworkId")
                    .ValueGeneratedNever();

                entity.Property(e => e.LongName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NetworkChannelAffiliation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_NetworkChannelAffiliation_Id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("NetworkChannelAffiliation", "mdm");

                entity.HasIndex(e => new { e.MdmnetworkId, e.MdmchannelId })
                    .HasName("UK_NetworkChannelAffiliation_MDMNetworkId_MDMChannelId")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.Property(e => e.MdmnetworkId).HasColumnName("MDMNetworkId");
            });

            modelBuilder.Entity<NetworkDaypartDemo>(entity =>
            {
                entity.ToTable("NetworkDaypartDemo", "inv");

                entity.HasIndex(e => new { e.NetworkId, e.DaypartId, e.DemoId, e.RatingSourceId, e.UserId })
                    .HasName("UK_NetworkDaypartDemo_NetworkId_DaypartId_DemoId_RatingSourceId_UserId")
                    .IsUnique();

                entity.HasOne(d => d.Daypart)
                    .WithMany(p => p.NetworkDaypartDemo)
                    .HasForeignKey(d => d.DaypartId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NetworkLengthFactor>(entity =>
            {
                entity.HasKey(e => e.LengthFactorId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("NetworkLengthFactor", "pricing");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCustom).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LengthFactorDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<NetworkLengthFactorDeviation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("NetworkLengthFactorDeviation", "pricing");

                entity.Property(e => e.RoundTo).HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.LengthFactor)
                    .WithMany(p => p.NetworkLengthFactorDeviation)
                    .HasForeignKey(d => d.LengthFactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NetworkLengthFactorSpots>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("NetworkLengthFactorSpots", "pricing");

                entity.Property(e => e.LengthFactor)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.LengthFactorNavigation)
                    .WithMany(p => p.NetworkLengthFactorSpots)
                    .HasForeignKey(d => d.LengthFactorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NetworkLengthFactorSpotsDeviation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("NetworkLengthFactorSpotsDeviation", "pricing");

                entity.Property(e => e.LengthFactor).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.LengthFactorNavigation)
                    .WithMany(p => p.NetworkLengthFactorSpotsDeviation)
                    .HasForeignKey(d => d.LengthFactorId);
            });

            modelBuilder.Entity<NetworkService>(entity =>
            {
                entity.ToTable("NetworkService", "service");

                entity.HasIndex(e => e.NetworkName)
                    .HasName("UK_NetworkService_NetworkName")
                    .IsUnique();

                entity.Property(e => e.NetworkName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NetworkServiceMapping>(entity =>
            {
                entity.ToTable("NetworkServiceMapping", "service");

                entity.HasOne(d => d.NetworkService)
                    .WithMany(p => p.NetworkServiceMapping)
                    .HasForeignKey(d => d.NetworkServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NetworkSpotLength>(entity =>
            {
                entity.HasKey(e => e.SpotLengthId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("NetworkSpotLength", "pricing");

                entity.HasIndex(e => e.SpotLength)
                    .HasName("UQ__NetworkS__8DE96302AA57F25D")
                    .IsUnique();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsCustom)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LengthFactor).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<NielsenSweepDates>(entity =>
            {
                entity.ToTable("NielsenSweepDates", "mdm");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.SweepName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NonDominantOptions>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_NonDominantOptions_Id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("NonDominantOptions", "inv");

                entity.Property(e => e.NonDominantAssign)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrbitProgramLocal>(entity =>
            {
                entity.ToTable("OrbitProgramLocal", "inv");

                entity.Property(e => e.Comment)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramTitle)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.OrbitProgramLocal)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrbitLocalProgram_Id_Program_ProgramId");
            });

            modelBuilder.Entity<OrbitProgramNetwork>(entity =>
            {
                entity.ToTable("OrbitProgramNetwork", "inv");

                entity.Property(e => e.Comment)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramTitle)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.OrbitProgramNetwork)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrbitProgramNetwork_Id_Program_ProgramId");
            });

            modelBuilder.Entity<PavSearchParameters>(entity =>
            {
                entity.ToTable("PavSearchParameters", "inv");

                entity.Property(e => e.MdmchannelId)
                    .IsRequired()
                    .HasColumnName("MDMChannelId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlaybackId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramAveragePeriod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surveys)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlaybackType>(entity =>
            {
                entity.ToTable("PlaybackType", "mdm");

                entity.Property(e => e.Id)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AlternativeId)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayId)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProgramAudience>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramAudience", "inv");

                entity.HasIndex(e => e.MdmmarketId)
                    .HasName("ClusteredIndex-20190716-150504")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => e.ProgramId)
                    .HasName("NonClusteredIndex-20190716-152834");

                entity.HasIndex(e => new { e.ProgramId, e.MdmmarketId })
                    .HasName("NonClusteredIndex-20190716-150920");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelID");

                entity.Property(e => e.MdmmarketId).HasColumnName("MDMMarketId");

                entity.Property(e => e.Rating).IsUnicode(false);

                entity.Property(e => e.RatingSourceId).HasColumnName("RatingSourceID");

                entity.Property(e => e.Rationale)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SurveyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProgramAudiencePav>(entity =>
            {
                entity.HasKey(e => e.PavId)
                    .HasName("PK_ProgramAudience_PavId")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramAudiencePav", "inv");

                entity.HasIndex(e => new { e.ProgramAudienceId, e.ProgramId })
                    .HasName("NonClusteredIndex-20190716-153456");

                entity.Property(e => e.Avg)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Days)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.Property(e => e.ProgramTitle)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rating).IsUnicode(false);

                entity.Property(e => e.SurveyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Weeks)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProgramAudience)
                    .WithMany(p => p.ProgramAudiencePav)
                    .HasForeignKey(d => d.ProgramAudienceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProgramDaypartLocal>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PKProgramDayparts")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramDaypartLocal", "inv");

                entity.HasIndex(e => new { e.ProgramId, e.DaypartId })
                    .HasName("UKProgramDayparts")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasOne(d => d.Daypart)
                    .WithMany(p => p.ProgramDaypartLocal)
                    .HasForeignKey(d => d.DaypartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProgramDa__Daypa__5A846E65");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramDaypartLocal)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProgramDa__Progr__59904A2C");
            });

            modelBuilder.Entity<ProgramDaypartNetwork>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PKProgramDaypartNetwork")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramDaypartNetwork", "inv");

                entity.HasIndex(e => new { e.ProgramId, e.DaypartId })
                    .HasName("UKProgramDaypartNetwork")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasOne(d => d.Daypart)
                    .WithMany(p => p.ProgramDaypartNetwork)
                    .HasForeignKey(d => d.DaypartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProgramDa__Daypa__5B78929E");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramDaypartNetwork)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProgramDa__Progr__5C6CB6D7");
            });

            modelBuilder.Entity<ProgramGenreLocal>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PKProgramGenreLocal")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramGenreLocal", "inv");

                entity.HasIndex(e => new { e.ProgramId, e.GenreId })
                    .HasName("UKProgramGenreLocal")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.ProgramGenreLocal)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramGenrelocaltoGenre");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramGenreLocal)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramGenreLocaltoProgram");
            });

            modelBuilder.Entity<ProgramGenreNetwork>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PKProgramGenreNetwork")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramGenreNetwork", "inv");

                entity.HasIndex(e => new { e.ProgramId, e.GenreId })
                    .HasName("UKProgramGenreNetwork")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.ProgramGenreNetwork)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramGenreNetworktoGenre");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramGenreNetwork)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramGenreNetworktoProgram");
            });

            modelBuilder.Entity<ProgramHiatusLocal>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PKProgramHiatus")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramHiatusLocal", "inv");

                entity.Property(e => e.HiatusEndDate).HasColumnType("datetime");

                entity.Property(e => e.HiatusStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramHiatusLocal)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProgramHi__Progr__61316BF4");
            });

            modelBuilder.Entity<ProgramHiatusNetwork>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PKProgramHiatusNetwork")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramHiatusNetwork", "inv");

                entity.Property(e => e.HiatusEndDate).HasColumnType("datetime");

                entity.Property(e => e.HiatusStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramHiatusNetwork)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProgramHi__Progr__6225902D");
            });

            modelBuilder.Entity<ProgramLocal>(entity =>
            {
                entity.HasKey(e => e.ProgramId)
                    .HasName("PKPROGRAM");

                entity.ToTable("ProgramLocal", "inv");

                entity.Property(e => e.Comment)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalIdentifier).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.Property(e => e.ProgramDescription)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramTitle)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.RatingSource)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ssucode)
                    .HasColumnName("SSUCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TranslationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Days)
                    .WithMany(p => p.ProgramLocal)
                    .HasForeignKey(d => d.DaysId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramGenreLocaltoDaycode");
            });

            modelBuilder.Entity<ProgramMatch>(entity =>
            {
                entity.HasKey(e => e.ProgramMatchId)
                    .HasName("PK_ProgramMatch_ProgramMatchId")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramMatch", "inv");

                entity.Property(e => e.ProgramMatch1)
                    .IsRequired()
                    .HasColumnName("ProgramMatch")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProgramNetwork>(entity =>
            {
                entity.HasKey(e => e.ProgramId)
                    .HasName("PKProgramNetwork");

                entity.ToTable("ProgramNetwork", "inv");

                entity.Property(e => e.Comment)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalIdentifier).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.MdmnetworkId).HasColumnName("MDMNetworkId");

                entity.Property(e => e.ProgramDescription)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramTitle)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.RatingSource)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZone)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TranslationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Days)
                    .WithMany(p => p.ProgramNetwork)
                    .HasForeignKey(d => d.DaysId)
                    .HasConstraintName("FK_ProgramGenreNetworktoDaycode");
            });

            modelBuilder.Entity<ProgramRate>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ProgramRate_Id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramRate", "pricing");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RateDate).HasColumnType("date");

                entity.Property(e => e.RateFor30).HasColumnType("money");

                entity.Property(e => e.RoundTo).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Ratecard)
                    .WithMany(p => p.ProgramRate)
                    .HasForeignKey(d => d.RatecardId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProgramTagLocal>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PKProgramTag")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramTagLocal", "inv");

                entity.HasIndex(e => new { e.ProgramId, e.TagId })
                    .HasName("UKProgramTag")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramTagLocal)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProgramTa__Progr__6501FCD8");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ProgramTagLocal)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramTaglocaltoTag");
            });

            modelBuilder.Entity<ProgramTagNetwork>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PKProgramTagNetwork")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("ProgramTagNetwork", "inv");

                entity.HasIndex(e => new { e.ProgramId, e.TagId })
                    .HasName("UKProgramTagNetwork")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramTagNetwork)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProgramTa__Progr__66EA454A");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ProgramTagNetwork)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramTagNetworktoTag");
            });

            modelBuilder.Entity<RangeDetails>(entity =>
            {
                entity.HasKey(e => e.RangeId);

                entity.ToTable("RangeDetails", "mdm");

                entity.Property(e => e.RangeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RateCardChannelMapping>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("RateCardChannelMapping", "pricing");

                entity.HasIndex(e => new { e.RatecardId, e.MarketId, e.MdmchannelId })
                    .HasName("Uk_RateCardChannelMapping")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.HasOne(d => d.Ratecard)
                    .WithMany(p => p.RateCardChannelMapping)
                    .HasForeignKey(d => d.RatecardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RateCardChannelMappingwithRatecard");
            });

            modelBuilder.Entity<RateCardNetworkMapping>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("RateCardNetworkMapping", "pricing");

                entity.HasIndex(e => new { e.RatecardId, e.MdmnetworkId, e.MarketId, e.MdmchannelId })
                    .HasName("Uk_RateCardNetworkMapping")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.Property(e => e.MdmnetworkId).HasColumnName("MDMNetworkId");

                entity.HasOne(d => d.Ratecard)
                    .WithMany(p => p.RateCardNetworkMapping)
                    .HasForeignKey(d => d.RatecardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RateCardNetworkMappingwithRatecard");
            });

            modelBuilder.Entity<RateCardUsers>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("RateCardUsers", "pricing");

                entity.HasIndex(e => new { e.RatecardId, e.UserId })
                    .HasName("Uk_RateCardUsers")
                    .IsUnique();

                entity.HasOne(d => d.Ratecard)
                    .WithMany(p => p.RateCardUsers)
                    .HasForeignKey(d => d.RatecardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RateCardUserswithRatecard");
            });

            modelBuilder.Entity<Ratecard>(entity =>
            {
                entity.HasKey(e => e.RatecardId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Ratecard", "pricing");

                entity.HasIndex(e => e.RatecardName)
                    .HasName("Uk_Ratecard")
                    .IsUnique();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExternalIdentifier).HasDefaultValueSql("(newid())");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LengthfactorGroupId).HasColumnName("lengthfactorGroupId");

                entity.Property(e => e.RatecardDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RatecardName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RatingSource>(entity =>
            {
                entity.ToTable("RatingSource", "mdm");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoundFactor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("RoundFactor", "pricing");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Display)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("decimal(9, 2)");
            });

            modelBuilder.Entity<SectionChannelMapping>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SectionChannelMapping", "pricing");

                entity.HasIndex(e => new { e.SectionId, e.MarketId, e.MdmchannelId })
                    .HasName("Uk_SectionChannelMapping")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SectionChannelMapping)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionChannelMappingWithRatecard");
            });

            modelBuilder.Entity<SectionLevel>(entity =>
            {
                entity.HasKey(e => e.SectionId)
                    .HasName("PK_SectionLevelSectionId")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SectionLevel", "pricing");

                entity.HasIndex(e => e.SectionName)
                    .HasName("UK_SectionLevelSectionName")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SectionDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Traffictranslator)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SectionNetworkMapping>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SectionNetworkMapping", "pricing");

                entity.HasIndex(e => new { e.SectionId, e.MdmnetworkId, e.MarketId, e.MdmchannelId })
                    .HasName("Uk_SectionNetworkMapping")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.Property(e => e.MdmnetworkId).HasColumnName("MDMNetworkId");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.SectionNetworkMapping)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SectionNetworkMappingwithRatecard");
            });

            modelBuilder.Entity<SpecialMarketMapping>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_SpecialMarketMapping_Id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SpecialMarketMapping", "mdm");
            });

            modelBuilder.Entity<SpotLengthChannelMapping>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SpotLengthChannelMapping", "pricing");

                entity.HasIndex(e => new { e.SpotLengthId, e.MarketId, e.MdmchannelId })
                    .HasName("Uk_SpotLengthChannelMapping")
                    .IsUnique();

                entity.Property(e => e.LengthFactor).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.HasOne(d => d.SpotLength)
                    .WithMany(p => p.SpotLengthChannelMapping)
                    .HasForeignKey(d => d.SpotLengthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpotLengthChannelMappingithSpotLength");
            });

            modelBuilder.Entity<SpotLengthNetworkMapping>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SpotLengthNetworkMapping", "pricing");

                entity.Property(e => e.LengthFactor).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.MdmnetworkId).HasColumnName("MDMNetworkId");

                entity.HasOne(d => d.SpotLength)
                    .WithMany(p => p.SpotLengthNetworkMapping)
                    .HasForeignKey(d => d.SpotLengthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpotLengthNetworkMappingithSpotLength");
            });

            modelBuilder.Entity<SubSampleIndicator>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_SubSampleIndicator_Id")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SubSampleIndicator", "mdm");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SurveySampleType>(entity =>
            {
                entity.ToTable("SurveySampleType", "mdm");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK_KeywordTag")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Tag", "inv");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TagDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TagInventoryRange>(entity =>
            {
                entity.ToTable("TagInventoryRange", "inv");

                entity.HasIndex(e => new { e.TagId, e.DaypartId })
                    .HasName("UQ_TagInventoryRange")
                    .IsUnique();

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagInventoryRange)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KeywordIn__TagId__6CA31EA0");
            });

            modelBuilder.Entity<TagMapping>(entity =>
            {
                entity.ToTable("TagMapping", "inv");

                entity.HasIndex(e => new { e.TagId, e.MarketId, e.MdmchannelId })
                    .HasName("UQ_TagMapping")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagMapping)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KeywordMa__TagId__6D9742D9");
            });

            modelBuilder.Entity<TagNetworkMapping>(entity =>
            {
                entity.ToTable("TagNetworkMapping", "inv");

                entity.HasIndex(e => new { e.TagId, e.MdmnetworkId, e.MarketId, e.MdmchannelId })
                    .HasName("UQ_TagNetworkMapping")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.Property(e => e.MdmnetworkId).HasColumnName("MDMNetworkId");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagNetworkMapping)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TagNetwor__TagId__60FC61CA");
            });

            modelBuilder.Entity<TagSaleRange>(entity =>
            {
                entity.ToTable("TagSaleRange", "inv");

                entity.HasIndex(e => e.TagId)
                    .HasName("UQ_TagSaleRange")
                    .IsUnique();

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.TagSaleRange)
                    .HasForeignKey<TagSaleRange>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__KeywordSa__TagId__6E8B6712");
            });

            modelBuilder.Entity<TbRatesBy>(entity =>
            {
                entity.ToTable("tbRatesBy", "pricing");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.ToTable("Tenant", "mdm");

                entity.Property(e => e.TenantName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TenantChannel>(entity =>
            {
                entity.ToTable("TenantChannel", "mdm");
            });

            modelBuilder.Entity<TenantMarket>(entity =>
            {
                entity.ToTable("TenantMarket", "mdm");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TenantMarket)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TenantNetwork>(entity =>
            {
                entity.ToTable("TenantNetwork", "mdm");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TenantNetwork)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TssufileComment>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_TSSUFileComment_ID")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TSSUFileComment", "inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Book)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.Demo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.Stream)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TssufileCommentDescription)
                    .HasColumnName("TSSUFileCommentDescription")
                    .IsUnicode(false);

                entity.Property(e => e.TssufileCommentService)
                    .HasColumnName("TSSUFileCommentService")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TssufileCommentType)
                    .HasColumnName("TSSUFileCommentType")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TssufileConfig>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_TSSUFileConfig_ID")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TSSUFileConfig", "inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TssufileConfigDescription)
                    .HasColumnName("TSSUFileConfigDescription")
                    .IsUnicode(false);

                entity.Property(e => e.TssufileConfigVersion)
                    .HasColumnName("TSSUFileConfigVersion")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TssufileDemo>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_TSSUFileDemo_ID")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TSSUFileDemo", "inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DemoList).IsUnicode(false);

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.TssufileDemoDescription)
                    .HasColumnName("TSSUFileDemoDescription")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TssufileDemoTrack>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_TSSUFileDemoTrack_ID")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TSSUFileDemoTrack", "inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Book)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ClusterId).HasColumnName("ClusterID");

                entity.Property(e => e.FootNote)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangedDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.Programming).IsUnicode(false);

                entity.Property(e => e.SubType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubTypeValue).IsUnicode(false);

                entity.Property(e => e.TimeShift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TssufileDemoTrackDescription)
                    .HasColumnName("TSSUFileDemoTrackDescription")
                    .IsUnicode(false);

                entity.Property(e => e.TssufileDemoType).HasColumnName("TSSUFileDemoType");
            });

            modelBuilder.Entity<TssufileHeader>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_TSSUFileHeader_ID")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TSSUFileHeader", "inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dma).HasColumnName("DMA");

                entity.Property(e => e.EndBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FileDateTime).HasColumnType("datetime");

                entity.Property(e => e.GeneralInfo).IsUnicode(false);

                entity.Property(e => e.Playback)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.RepCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartBook)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TssufileName)
                    .HasColumnName("TSSUFileName")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TssufileMaster>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_TSSUFileMaster_ID")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TSSUFileMaster", "inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComprogramNumber).HasColumnName("COMProgramNumber");

                entity.Property(e => e.DayTime).IsUnicode(false);

                entity.Property(e => e.Dayparts)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsSsuforSale).HasColumnName("IsSSUForSale");

                entity.Property(e => e.IsSsulocal).HasColumnName("IsSSULocal");

                entity.Property(e => e.LastChangedDate).HasColumnType("datetime");

                entity.Property(e => e.MasterUid).HasColumnName("MasterUID");

                entity.Property(e => e.NiprogramNumber).HasColumnName("NIProgramNumber");

                entity.Property(e => e.PrintDayTime).IsUnicode(false);

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProgramTitle).IsUnicode(false);

                entity.Property(e => e.Ssuabbrev)
                    .HasColumnName("SSUAbbrev")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Ssucode)
                    .HasColumnName("SSUCode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SsudateCode).HasColumnName("SSUDateCode");

                entity.Property(e => e.Ssuenddate)
                    .HasColumnName("SSUEnddate")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SsustartDateTime)
                    .HasColumnName("SSUStartDateTime")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ssuuid).HasColumnName("SSUUID");

                entity.Property(e => e.StationCalls)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StationMedia)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TssufileMasterDescription)
                    .HasColumnName("TSSUFileMasterDescription")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TssufileMasterTypes)
                    .HasColumnName("TSSUFileMasterTypes")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TssufileTrailer>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_TSSUFileTrailer_ID")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TSSUFileTrailer", "inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GeneralInfo).IsUnicode(false);

                entity.Property(e => e.ProcessDateTime).HasColumnType("datetime");

                entity.Property(e => e.TssufileTrailerDescription)
                    .HasColumnName("TSSUFileTrailerDescription")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TssumasterDaypartMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .HasName("PK_TSSUMasterDaypartMapping_MappingID")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TSSUMasterDaypartMapping", "inv");

                entity.Property(e => e.MappingId).HasColumnName("MappingID");

                entity.Property(e => e.CampaignDaypart)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ssudaypart)
                    .HasColumnName("SSUDaypart")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TssumasterDemoMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId)
                    .HasName("PK_TSSUDemoMapping_MappingID")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("TSSUMasterDemoMapping", "inv");

                entity.Property(e => e.MappingId).HasColumnName("MappingID");

                entity.Property(e => e.CampaignDemo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignDemoId).HasColumnName("CampaignDemoID");

                entity.Property(e => e.Tssudemo)
                    .HasColumnName("TSSUDemo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserChannel>(entity =>
            {
                entity.ToTable("UserChannel", "usr");

                entity.HasIndex(e => new { e.UserId, e.MarketId, e.MdmchannelId })
                    .HasName("IX_UserChannel")
                    .IsUnique();

                entity.Property(e => e.MdmchannelId).HasColumnName("MDMChannelId");

                entity.HasOne(d => d.Mdmchannel)
                    .WithMany(p => p.UserChannel)
                    .HasForeignKey(d => d.MdmchannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserChann__MDMCh__2610A626");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserChannel)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserChann__UserI__251C81ED");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserDetail", "usr");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MiddelName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMarket>(entity =>
            {
                entity.ToTable("UserMarket", "usr");

                entity.HasIndex(e => new { e.UserId, e.MdmmarketId })
                    .HasName("UQ_UserMarket")
                    .IsUnique();

                entity.Property(e => e.MdmmarketId).HasColumnName("MDMMarketId");

                entity.HasOne(d => d.Mdmmarket)
                    .WithMany(p => p.UserMarket)
                    .HasForeignKey(d => d.MdmmarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserMarke__MDMMa__47A6A41B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMarket)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserMarke__UserI__489AC854");
            });

            modelBuilder.Entity<UserMarketGroup>(entity =>
            {
                entity.HasKey(e => e.MarketGroupId)
                    .HasName("PK_MarketGroup");

                entity.ToTable("UserMarketGroup", "usr");

                entity.HasIndex(e => e.MarketGroupName)
                    .HasName("UQ__UserMark__599EA339373ADD47")
                    .IsUnique();

                entity.Property(e => e.MarketGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMarketGroupDetails>(entity =>
            {
                entity.HasKey(e => new { e.MarketGroupId, e.MdmmarketId });

                entity.ToTable("UserMarketGroupDetails", "usr");

                entity.Property(e => e.MdmmarketId).HasColumnName("MDMMarketId");

                entity.HasOne(d => d.MarketGroup)
                    .WithMany(p => p.UserMarketGroupDetails)
                    .HasForeignKey(d => d.MarketGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserMarke__Marke__00AA174D");
            });

            modelBuilder.Entity<UserTenantChannel>(entity =>
            {
                entity.HasKey(e => e.UserChannelId);

                entity.ToTable("UserTenantChannel", "usr");

                entity.HasIndex(e => new { e.UserId, e.ChannelServiceId })
                    .HasName("UN_UserTenantChannel")
                    .IsUnique();
            });

            modelBuilder.Entity<UserTenantMarket>(entity =>
            {
                entity.HasKey(e => e.UserMarketId);

                entity.ToTable("UserTenantMarket", "usr");

                entity.HasIndex(e => new { e.UserId, e.MarketServiceId })
                    .HasName("UN_UserTenantMarket")
                    .IsUnique();
            });

            modelBuilder.Entity<UserTenantNetwork>(entity =>
            {
                entity.HasKey(e => e.UserNetworkId);

                entity.ToTable("UserTenantNetwork", "usr");

                entity.HasIndex(e => new { e.UserId, e.NetworkServiceId })
                    .HasName("UN_UserTenantNetwork")
                    .IsUnique();
            });

            modelBuilder.Entity<VideaAcknowledge>(entity =>
            {
                entity.ToTable("VideaAcknowledge", "inv");

                entity.Property(e => e.Acknowledgement)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Response)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SentRecordJson)
                    .HasColumnName("SentRecordJSON")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}