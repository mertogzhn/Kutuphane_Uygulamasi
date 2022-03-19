using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace kutuphane24.Models
{
    public partial class KutuphaneDBContext : DbContext
    {
        public KutuphaneDBContext()
        {
        }

        public KutuphaneDBContext(DbContextOptions<KutuphaneDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCezalar> TblCezalars { get; set; }
        public virtual DbSet<TblHareket> TblHarekets { get; set; }
        public virtual DbSet<TblKasa> TblKasas { get; set; }
        public virtual DbSet<TblKategori> TblKategoris { get; set; }
        public virtual DbSet<TblKitap> TblKitaps { get; set; }
        public virtual DbSet<TblPersonel> TblPersonels { get; set; }
        public virtual DbSet<TblUye> TblUyes { get; set; }
        public virtual DbSet<TblYazar> TblYazars { get; set; }
        public virtual DbSet<VwKitap> VwKitaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-VJ5O2E5;Initial Catalog=KutuphaneDB;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<TblCezalar>(entity =>
            {
                entity.HasKey(e => e.CezaId);

                entity.ToTable("TblCezalar");

                entity.Property(e => e.CezaId).HasColumnName("CezaID");

                entity.Property(e => e.Başlangıç).HasColumnType("smalldatetime");

                entity.Property(e => e.Bitiş).HasColumnType("smalldatetime");

                entity.Property(e => e.Para).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.HareketNavigation)
                    .WithMany(p => p.TblCezalars)
                    .HasForeignKey(d => d.Hareket)
                    .HasConstraintName("FK_TblCezalar_TblHareket");

                entity.HasOne(d => d.UyeNavigation)
                    .WithMany(p => p.TblCezalars)
                    .HasForeignKey(d => d.Uye)
                    .HasConstraintName("FK_TblCezalar_TblUye");
            });

            modelBuilder.Entity<TblHareket>(entity =>
            {
                entity.HasKey(e => e.HareketId);

                entity.ToTable("TblHareket");

                entity.Property(e => e.HareketId).HasColumnName("HareketID");

                entity.Property(e => e.AlısTarih).HasColumnType("smalldatetime");

                entity.Property(e => e.İadeTarih).HasColumnType("smalldatetime");

                entity.HasOne(d => d.KitapNavigation)
                    .WithMany(p => p.TblHarekets)
                    .HasForeignKey(d => d.Kitap)
                    .HasConstraintName("FK_TblHareket_TblKitap");

                entity.HasOne(d => d.UyeNavigation)
                    .WithMany(p => p.TblHarekets)
                    .HasForeignKey(d => d.Uye)
                    .HasConstraintName("FK_TblHareket_TblUye");
            });

            modelBuilder.Entity<TblKasa>(entity =>
            {
                entity.HasKey(e => e.KasaId);

                entity.ToTable("TblKasa");

                entity.Property(e => e.KasaId).HasColumnName("KasaID");

                entity.Property(e => e.Ay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tutar).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<TblKategori>(entity =>
            {
                entity.HasKey(e => e.KategoriId);

                entity.ToTable("TblKategori");

                entity.Property(e => e.KategoriId).HasColumnName("KategoriID");

                entity.Property(e => e.KategoriAd)
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TblKitap>(entity =>
            {
                entity.HasKey(e => e.KitapId);

                entity.ToTable("TblKitap");

                entity.Property(e => e.KitapId).HasColumnName("KitapID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BasimYil)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Durum).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sayfa)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YayinEvi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.KategoriNavigation)
                    .WithMany(p => p.TblKitaps)
                    .HasForeignKey(d => d.Kategori)
                    .HasConstraintName("FK_TblKitap_TblKategori");

                entity.HasOne(d => d.YazarNavigation)
                    .WithMany(p => p.TblKitaps)
                    .HasForeignKey(d => d.Yazar)
                    .HasConstraintName("FK_TblKitap_TblYazar");
            });

            modelBuilder.Entity<TblPersonel>(entity =>
            {
                entity.HasKey(e => e.PersonelId);

                entity.ToTable("TblPersonel");

                entity.Property(e => e.PersonelId).HasColumnName("PersonelID");

                entity.Property(e => e.Personel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUye>(entity =>
            {
                entity.HasKey(e => e.UyeId);

                entity.ToTable("TblUye");

                entity.Property(e => e.UyeId).HasColumnName("UyeID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AD");

                entity.Property(e => e.Fotograf)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KullaniciAdi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Okul)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sifre)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblYazar>(entity =>
            {
                entity.HasKey(e => e.YazarId);

                entity.ToTable("TblYazar");

                entity.Property(e => e.YazarId).HasColumnName("YazarID");

                entity.Property(e => e.Ad)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Detay)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Soyad)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwKitap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Kitap");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BasimYil)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Durum)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.KategoriAd)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.KitapId).HasColumnName("KitapID");

                entity.Property(e => e.Sayfa)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.YayinEvi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YazarAdi)
                    .HasMaxLength(61)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
