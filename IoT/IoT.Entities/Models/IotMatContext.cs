/*using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IoT.Entities.Models
{
    public partial class IotMatContext : DbContext
    {
        public IotMatContext()
        {
        }

        public IotMatContext(DbContextOptions<IotMatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirlineList> AirlineList { get; set; }
        public virtual DbSet<BhsAlarms> BhsAlarms { get; set; }
        public virtual DbSet<BhsAtr> BhsAtr { get; set; }
        public virtual DbSet<BhsBpi> BhsBpi { get; set; }
        public virtual DbSet<BhsConveyorInfo> BhsConveyorInfo { get; set; }
        public virtual DbSet<BhsConveyorState> BhsConveyorState { get; set; }
        public virtual DbSet<BhsConveyors> BhsConveyors { get; set; }
        public virtual DbSet<BhsCounters> BhsCounters { get; set; }
        public virtual DbSet<BhsDashboardV2> BhsDashboardV2 { get; set; }
        public virtual DbSet<BhsLog> BhsLog { get; set; }
        public virtual DbSet<BhsVariableState> BhsVariableState { get; set; }
        public virtual DbSet<Carruseles> Carruseles { get; set; }
        public virtual DbSet<ContactPhotos> ContactPhotos { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<DeviceParameters> DeviceParameters { get; set; }
        public virtual DbSet<Devices> Devices { get; set; }
        public virtual DbSet<ElectricityConsumptions> ElectricityConsumptions { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<PhoneCalls> PhoneCalls { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<TrafficConsumptions> TrafficConsumptions { get; set; }
        public virtual DbSet<UserClaims> UserClaims { get; set; }
        public virtual DbSet<UserPhotos> UserPhotos { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.100.22.48;Database=IotMat;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirlineList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("airline_list");

                entity.Property(e => e.AirlineName)
                    .HasColumnName("airline_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineState).HasColumnName("airline_state");

                entity.Property(e => e.CountryTerritory)
                    .HasColumnName("country_territory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IataDesignator)
                    .HasColumnName("iata_designator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IcaoDesignator)
                    .HasColumnName("icao_designator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TreeDigitCode).HasColumnName("tree_digit_code");
            });

            modelBuilder.Entity<BhsAlarms>(entity =>
            {
                entity.ToTable("bhs_alarms");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aux)
                    .IsRequired()
                    .HasColumnName("aux")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateRegister).HasColumnType("datetime");

                entity.Property(e => e.IdConveyors).HasColumnName("idConveyors");
            });

            modelBuilder.Entity<BhsAtr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bhs_atr");

                entity.Property(e => e.Aux)
                    .HasColumnName("aux")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bagtag)
                    .HasColumnName("bagtag")
                    .HasMaxLength(50);

                entity.Property(e => e.DateRegister).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdAtr).HasColumnName("idAtr");
            });

            modelBuilder.Entity<BhsBpi>(entity =>
            {
                entity.ToTable("bhs_bpi");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aux)
                    .HasColumnName("aux")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Bagtag)
                    .HasColumnName("bagtag")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.DateRegister).HasColumnType("datetime");

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BhsConveyorInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bhs_ConveyorInfo");

                entity.Property(e => e.CoordX)
                    .HasColumnName("coordX")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CoordY)
                    .HasColumnName("coordY")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateRegister).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdConveyors).HasColumnName("idConveyors");

                entity.Property(e => e.Ubication)
                    .HasColumnName("ubication")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BhsConveyorState>(entity =>
            {
                entity.ToTable("bhs_ConveyorState");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BhsConveyors>(entity =>
            {
                entity.ToTable("bhs_conveyors");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Current)
                    .HasColumnName("current")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateRegister).HasColumnType("datetime");

                entity.Property(e => e.IdConveyors).HasColumnName("idConveyors");

                entity.Property(e => e.IdFailure)
                    .HasColumnName("idFailure")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Power)
                    .HasColumnName("power")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BhsCounters>(entity =>
            {
                entity.ToTable("bhs_counters");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aux)
                    .HasColumnName("aux")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateRegister).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BhsDashboardV2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bhs_DashboardV2");

                entity.Property(e => e.IdConveyor).HasColumnName("idConveyor");

                entity.Property(e => e.ValueDateTime).HasColumnType("date");
            });

            modelBuilder.Entity<BhsLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bhs_Log");

                entity.Property(e => e.Context)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExecutionTime)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Level)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Method)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parameters)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Thread)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BhsVariableState>(entity =>
            {
                entity.ToTable("bhs_variableState");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aux)
                    .HasColumnName("aux")
                    .HasMaxLength(50);

                entity.Property(e => e.DateRegister)
                    .HasColumnName("dateRegister")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Carruseles>(entity =>
            {
                entity.ToTable("carruseles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Carrusel).HasColumnName("carrusel");

                entity.Property(e => e.IdAirlineList).HasColumnName("id_airline_list");

                entity.Property(e => e.RegisterDate)
                    .HasColumnName("register_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ContactPhotos>(entity =>
            {
                entity.ToTable("ContactPhotos", "iot_core");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Image).IsRequired();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ContactPhotos)
                    .HasForeignKey<ContactPhotos>(d => d.Id);
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.ToTable("Contacts", "iot_core");

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.PhoneNumber).IsRequired();
            });

            modelBuilder.Entity<DeviceParameters>(entity =>
            {
                entity.ToTable("DeviceParameters", "iot_core");

                entity.HasIndex(e => e.CreatedByUserId);

                entity.HasIndex(e => e.DeviceId);

                entity.HasIndex(e => e.UpdatedByUserId);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.DeviceParametersCreatedByUser)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.DeviceParameters)
                    .HasForeignKey(d => d.DeviceId);

                entity.HasOne(d => d.UpdatedByUser)
                    .WithMany(p => p.DeviceParametersUpdatedByUser)
                    .HasForeignKey(d => d.UpdatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Devices>(entity =>
            {
                entity.ToTable("Devices", "iot_core");

                entity.HasIndex(e => e.CreatedByUserId);

                entity.HasIndex(e => e.UpdatedByUserId);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.CreatedByUser)
                    .WithMany(p => p.DevicesCreatedByUser)
                    .HasForeignKey(d => d.CreatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UpdatedByUser)
                    .WithMany(p => p.DevicesUpdatedByUser)
                    .HasForeignKey(d => d.UpdatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ElectricityConsumptions>(entity =>
            {
                entity.ToTable("ElectricityConsumptions", "iot_core");
            });

            modelBuilder.Entity<Logs>(entity =>
            {
                entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<PhoneCalls>(entity =>
            {
                entity.ToTable("PhoneCalls", "iot_core");

                entity.HasIndex(e => e.ContactId);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.PhoneCalls)
                    .HasForeignKey(d => d.ContactId);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("Roles", "iot_core");

                entity.Property(e => e.Discriminator).IsRequired();
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.ToTable("Settings", "iot_core");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ThemeName).IsRequired();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Settings)
                    .HasForeignKey<Settings>(d => d.Id);
            });

            modelBuilder.Entity<TrafficConsumptions>(entity =>
            {
                entity.ToTable("TrafficConsumptions", "iot_core");
            });

            modelBuilder.Entity<UserClaims>(entity =>
            {
                entity.ToTable("UserClaims", "iot_core");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.ClaimType).IsRequired();

                entity.Property(e => e.ClaimValue).IsRequired();

                entity.Property(e => e.Discriminator).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserPhotos>(entity =>
            {
                entity.ToTable("UserPhotos", "iot_core");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Image).IsRequired();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.UserPhotos)
                    .HasForeignKey<UserPhotos>(d => d.Id);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("UserRoles", "iot_core");

                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.Discriminator).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "iot_core");

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.Login).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
*/