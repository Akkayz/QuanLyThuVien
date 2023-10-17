using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyThuVien.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=OPENLIBRARY")
        {
        }

        public virtual DbSet<BINHLUAN> BINHLUANs { get; set; }
        public virtual DbSet<CHINHANH> CHINHANHs { get; set; }
        public virtual DbSet<CHUYENNGANH> CHUYENNGANHs { get; set; }
        public virtual DbSet<DAUSACH> DAUSACHes { get; set; }
        public virtual DbSet<DOCGIA> DOCGIAs { get; set; }
        public virtual DbSet<LOAIDOCGIA> LOAIDOCGIAs { get; set; }
        public virtual DbSet<LOAINHANVIEN> LOAINHANVIENs { get; set; }
        public virtual DbSet<MUONSACH> MUONSACHes { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<YEUCAU> YEUCAUs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BINHLUAN>()
                .Property(e => e.MaDG)
                .IsFixedLength();

            modelBuilder.Entity<CHINHANH>()
                .HasMany(e => e.SACHes)
                .WithRequired(e => e.CHINHANH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAUSACH>()
                .HasMany(e => e.BINHLUANs)
                .WithRequired(e => e.DAUSACH)
                .HasForeignKey(e => e.MaSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAUSACH>()
                .HasMany(e => e.SACHes)
                .WithRequired(e => e.DAUSACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCGIA>()
                .Property(e => e.MaDG)
                .IsFixedLength();

            modelBuilder.Entity<DOCGIA>()
                .HasMany(e => e.BINHLUANs)
                .WithRequired(e => e.DOCGIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCGIA>()
                .HasMany(e => e.MUONSACHes)
                .WithRequired(e => e.DOCGIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MUONSACH>()
                .Property(e => e.MaDG)
                .IsFixedLength();

            modelBuilder.Entity<MUONSACH>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .Property(e => e.MaSach)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.MUONSACHes)
                .WithRequired(e => e.SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<YEUCAU>()
                .Property(e => e.MaDG)
                .IsFixedLength();
        }
    }
}
