namespace QuanLyBanGiay.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebBanGiay : DbContext
    {
        public WebBanGiay()
            : base("name=WebBanGiay")
        {
        }

        public virtual DbSet<tChiTietGioHang> tChiTietGioHang { get; set; }
        public virtual DbSet<tChiTietHoaDon> tChiTietHoaDon { get; set; }
        public virtual DbSet<tGioHang> tGioHang { get; set; }
        public virtual DbSet<tHoaDon> tHoaDon { get; set; }
        public virtual DbSet<tSanPham> tSanPham { get; set; }
        public virtual DbSet<tTaiKhoan> tTaiKhoan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tChiTietGioHang>()
                .Property(e => e.MaSP)
                .IsFixedLength();

            modelBuilder.Entity<tChiTietHoaDon>()
                .Property(e => e.MaSP)
                .IsFixedLength();

            modelBuilder.Entity<tChiTietHoaDon>()
                .Property(e => e.GhiChu)
                .IsFixedLength();

            modelBuilder.Entity<tGioHang>()
                .HasMany(e => e.tChiTietGioHang)
                .WithRequired(e => e.tGioHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tHoaDon>()
                .HasMany(e => e.tChiTietHoaDon)
                .WithRequired(e => e.tHoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tSanPham>()
                .Property(e => e.MaSP)
                .IsFixedLength();

            modelBuilder.Entity<tSanPham>()
                .HasMany(e => e.tChiTietGioHang)
                .WithRequired(e => e.tSanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tSanPham>()
                .HasMany(e => e.tChiTietHoaDon)
                .WithRequired(e => e.tSanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tTaiKhoan>()
                .HasMany(e => e.tHoaDon)
                .WithRequired(e => e.tTaiKhoan)
                .WillCascadeOnDelete(false);
        }
    }
}
