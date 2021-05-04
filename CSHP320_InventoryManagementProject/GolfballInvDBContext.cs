using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CSHP320_InventoryManagementProject
{
    public partial class GolfballInvDBContext : DbContext
    {
        public GolfballInvDBContext()
        {
        }

        public GolfballInvDBContext(DbContextOptions<GolfballInvDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Model> Models { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-H7D4IOV\\SQLEXPRESS;Initial Catalog=GolfballInvDB;integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.BrandNum);

                entity.ToTable("Brand");

                entity.Property(e => e.BrandNum).HasMaxLength(6);

                entity.Property(e => e.Brand1)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("Brand");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.ImageNum);

                entity.Property(e => e.ImageNum).HasMaxLength(6);

                entity.Property(e => e.Image1)
                    .IsRequired()
                    .HasColumnType("image")
                    .HasColumnName("Image");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.InvNum);

                entity.ToTable("Inventory");

                entity.Property(e => e.InvNum).ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("smallmoney");

                entity.Property(e => e.InvValue).HasColumnType("smallmoney");

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.Qty).HasColumnName("QTY");
            });

            modelBuilder.Entity<Model>(entity =>
            {
                entity.HasKey(e => e.ModelNum);

                entity.ToTable("Model");

                entity.Property(e => e.ModelNum).HasMaxLength(6);

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
