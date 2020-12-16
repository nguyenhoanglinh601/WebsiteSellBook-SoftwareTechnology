using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebsiteBanSach.Models;

namespace WebsiteBanSach.Data
{
    public class WebBanSachContext : DbContext
    {
        public WebBanSachContext(DbContextOptions<WebBanSachContext> options)
            : base(options)
        {
        }

        public DbSet<ChiTietDonHang> TapHopChiTietDonHang { get; set; }
        public DbSet<ChiTietGiamGia> TapHopChiTietGiamGia { get; set; }
        public DbSet<ChiTietSach> TapHopChiTietSach { get; set; }
        public DbSet<DonHang> TapHopDonHang { get; set; }
        public DbSet<GiamGia> TapHopGiamGia { get; set; }
        public DbSet<LoaiSach> TapHopLoaiSach { get; set; }
        public DbSet<NhaXuatBan> TapHopNhaXuatBan { get; set; }
        public DbSet<Sach> TapHopSach { get; set; }
        public DbSet<TacGia> TapHopTacGia { get; set; }
        public DbSet<TaiKhoanKhachHang> TapHopTaiKhoanKhachHang { get; set; }
        public DbSet<TaiKhoanNhanVien> TapHopTaiKhoanNhanVien { get; set; }
        public DbSet<TrangThai> TapHopTrangThai { get; set; }
        public DbSet<TrangThaiDonHang> TapHopTrangThaiDonHang { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonHang>()
                .HasKey(o => new { o.idDonHang, o.idSach });
            modelBuilder.Entity<ChiTietGiamGia>()
                .HasKey(o => new { o.idDonHang, o.idGiamGia });
            modelBuilder.Entity<ChiTietSach>()
                .HasKey(o => new { o.idSach, o.idTacGia });
            modelBuilder.Entity<DonHang>()
                .HasKey(o => o.idDonHang);
            modelBuilder.Entity<GiamGia>()
                .HasKey(o => o.idGiamGia);
            modelBuilder.Entity<LoaiSach>()
                .HasKey(o => o.idLoai);
            modelBuilder.Entity<NhaXuatBan>()
                .HasKey(o => o.idNhaXuatBan);
            modelBuilder.Entity<Sach>()
                .HasKey(o => new { o.idSach, o.lanTaiBan });
            modelBuilder.Entity<TacGia>()
                .HasKey(o => o.idTacGia);
            modelBuilder.Entity<TaiKhoanKhachHang>()
                .HasKey(o => o.idKhachHang);
            modelBuilder.Entity<TaiKhoanNhanVien>()
                .HasKey(o => o.idNhanVien);
            modelBuilder.Entity<TrangThai>()
                .HasKey(o => o.idTrangThai);
            modelBuilder.Entity<TrangThaiDonHang>()
                .HasKey(o => new { o.idDonHang, o.idTrangThai });
        }
    }
}
