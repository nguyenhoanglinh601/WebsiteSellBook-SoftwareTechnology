﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebsiteBanSach.Data;

namespace WebsiteBanSach.Migrations
{
    [DbContext(typeof(WebBanSachContext))]
    partial class WebBanSachContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WebsiteBanSach.Models.ChiTietDonHang", b =>
                {
                    b.Property<int>("idDonHang")
                        .HasColumnType("int");

                    b.Property<int>("idSach")
                        .HasColumnType("int");

                    b.Property<decimal>("giaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("sachidSach")
                        .HasColumnType("int");

                    b.Property<int?>("sachlanTaiBan")
                        .HasColumnType("int");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.HasKey("idDonHang", "idSach");

                    b.HasIndex("sachidSach", "sachlanTaiBan");

                    b.ToTable("TapHopChiTietDonHang");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.ChiTietGiamGia", b =>
                {
                    b.Property<int>("idDonHang")
                        .HasColumnType("int");

                    b.Property<int>("idGiamGia")
                        .HasColumnType("int");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.HasKey("idDonHang", "idGiamGia");

                    b.HasIndex("idGiamGia");

                    b.ToTable("TapHopChiTietGiamGia");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.ChiTietSach", b =>
                {
                    b.Property<int>("idSach")
                        .HasColumnType("int");

                    b.Property<int>("idTacGia")
                        .HasColumnType("int");

                    b.Property<int?>("sachidSach")
                        .HasColumnType("int");

                    b.Property<int?>("sachlanTaiBan")
                        .HasColumnType("int");

                    b.HasKey("idSach", "idTacGia");

                    b.HasIndex("idTacGia");

                    b.HasIndex("sachidSach", "sachlanTaiBan");

                    b.ToTable("TapHopChiTietSach");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.DonHang", b =>
                {
                    b.Property<int>("idDonHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("VAT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("diaChiGiaoHang")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idKhachHang")
                        .HasColumnType("int");

                    b.Property<decimal>("phiGiaoHang")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("soDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("taiKhoanKhachHangidKhachHang")
                        .HasColumnType("int");

                    b.Property<string>("tenNguoiNhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("thoiGianDatHang")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("thoiGianGiaoHangDuKien")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("tongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("idDonHang");

                    b.HasIndex("taiKhoanKhachHangidKhachHang");

                    b.ToTable("TapHopDonHang");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.GiamGia", b =>
                {
                    b.Property<int>("idGiamGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("soTienGiam")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("tenChuongTrinh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idGiamGia");

                    b.ToTable("TapHopGiamGia");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.LoaiSach", b =>
                {
                    b.Property<int>("idLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("moTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idLoai");

                    b.ToTable("TapHopLoaiSach");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.NhaXuatBan", b =>
                {
                    b.Property<int>("idNhaXuatBan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idNhaXuatBan");

                    b.ToTable("TapHopNhaXuatBan");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.Sach", b =>
                {
                    b.Property<int>("idSach")
                        .HasColumnType("int");

                    b.Property<int>("lanTaiBan")
                        .HasColumnType("int");

                    b.Property<decimal>("giaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("hinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idNhaXuatBan")
                        .HasColumnType("int");

                    b.Property<int?>("loaiSachidLoai")
                        .HasColumnType("int");

                    b.Property<int>("maLoai")
                        .HasColumnType("int");

                    b.Property<string>("moTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("nhaXuatBanidNhaXuatBan")
                        .HasColumnType("int");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("idSach", "lanTaiBan");

                    b.HasIndex("loaiSachidLoai");

                    b.HasIndex("nhaXuatBanidNhaXuatBan");

                    b.ToTable("TapHopSach");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.TacGia", b =>
                {
                    b.Property<int>("idTacGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<DateTime>("namSinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("quocTich")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTacGia");

                    b.ToTable("TapHopTacGia");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.TaiKhoanKhachHang", b =>
                {
                    b.Property<int>("idKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("diemMuaHang")
                        .HasColumnType("int");

                    b.Property<string>("gioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("taiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.HasKey("idKhachHang");

                    b.ToTable("TapHopTaiKhoanKhachHang");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.TaiKhoanNhanVien", b =>
                {
                    b.Property<int>("idNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("matKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenNhanVien")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("trangThai")
                        .HasColumnType("bit");

                    b.Property<string>("vaiTro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idNhanVien");

                    b.ToTable("TapHopTaiKhoanNhanVien");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.TrangThai", b =>
                {
                    b.Property<int>("idTrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("kieuTrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTrangThai");

                    b.ToTable("TapHopTrangThai");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.TrangThaiDonHang", b =>
                {
                    b.Property<int>("idDonHang")
                        .HasColumnType("int");

                    b.Property<int>("idTrangThai")
                        .HasColumnType("int");

                    b.Property<int?>("donHangidDonHang")
                        .HasColumnType("int");

                    b.Property<int>("idNhanVien")
                        .HasColumnType("int");

                    b.Property<int?>("taiKhoanNhanVienidNhanVien")
                        .HasColumnType("int");

                    b.Property<DateTime>("thoiGian")
                        .HasColumnType("datetime2");

                    b.Property<int?>("trangThaiidTrangThai")
                        .HasColumnType("int");

                    b.HasKey("idDonHang", "idTrangThai");

                    b.HasIndex("donHangidDonHang");

                    b.HasIndex("taiKhoanNhanVienidNhanVien");

                    b.HasIndex("trangThaiidTrangThai");

                    b.ToTable("TapHopTrangThaiDonHang");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.ChiTietDonHang", b =>
                {
                    b.HasOne("WebsiteBanSach.Models.DonHang", "donHang")
                        .WithMany("danhSachChiTietDonHang")
                        .HasForeignKey("idDonHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebsiteBanSach.Models.Sach", "sach")
                        .WithMany("danhSachChiTietDonHang")
                        .HasForeignKey("sachidSach", "sachlanTaiBan");

                    b.Navigation("donHang");

                    b.Navigation("sach");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.ChiTietGiamGia", b =>
                {
                    b.HasOne("WebsiteBanSach.Models.DonHang", "donHang")
                        .WithMany("danhSachChiTietGiamGia")
                        .HasForeignKey("idDonHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebsiteBanSach.Models.GiamGia", "giamGia")
                        .WithMany("danhSachChiTietGiamGia")
                        .HasForeignKey("idGiamGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("donHang");

                    b.Navigation("giamGia");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.ChiTietSach", b =>
                {
                    b.HasOne("WebsiteBanSach.Models.TacGia", "tacGia")
                        .WithMany("tapHopChiTietSach")
                        .HasForeignKey("idTacGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebsiteBanSach.Models.Sach", "sach")
                        .WithMany("tapHopChiTietSach")
                        .HasForeignKey("sachidSach", "sachlanTaiBan");

                    b.Navigation("sach");

                    b.Navigation("tacGia");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.DonHang", b =>
                {
                    b.HasOne("WebsiteBanSach.Models.TaiKhoanKhachHang", "taiKhoanKhachHang")
                        .WithMany("danhSachDonHang")
                        .HasForeignKey("taiKhoanKhachHangidKhachHang");

                    b.Navigation("taiKhoanKhachHang");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.Sach", b =>
                {
                    b.HasOne("WebsiteBanSach.Models.LoaiSach", "loaiSach")
                        .WithMany("tapHopSach")
                        .HasForeignKey("loaiSachidLoai");

                    b.HasOne("WebsiteBanSach.Models.NhaXuatBan", "nhaXuatBan")
                        .WithMany("tapHopSach")
                        .HasForeignKey("nhaXuatBanidNhaXuatBan");

                    b.Navigation("loaiSach");

                    b.Navigation("nhaXuatBan");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.TrangThaiDonHang", b =>
                {
                    b.HasOne("WebsiteBanSach.Models.DonHang", "donHang")
                        .WithMany("danhSachTrangThaiDonHang")
                        .HasForeignKey("donHangidDonHang");

                    b.HasOne("WebsiteBanSach.Models.TaiKhoanNhanVien", "taiKhoanNhanVien")
                        .WithMany("danhSachTrangThaiDonHang")
                        .HasForeignKey("taiKhoanNhanVienidNhanVien");

                    b.HasOne("WebsiteBanSach.Models.TrangThai", "trangThai")
                        .WithMany("danhSachTrangThaiDonHang")
                        .HasForeignKey("trangThaiidTrangThai");

                    b.Navigation("donHang");

                    b.Navigation("taiKhoanNhanVien");

                    b.Navigation("trangThai");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.DonHang", b =>
                {
                    b.Navigation("danhSachChiTietDonHang");

                    b.Navigation("danhSachChiTietGiamGia");

                    b.Navigation("danhSachTrangThaiDonHang");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.GiamGia", b =>
                {
                    b.Navigation("danhSachChiTietGiamGia");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.LoaiSach", b =>
                {
                    b.Navigation("tapHopSach");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.NhaXuatBan", b =>
                {
                    b.Navigation("tapHopSach");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.Sach", b =>
                {
                    b.Navigation("danhSachChiTietDonHang");

                    b.Navigation("tapHopChiTietSach");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.TacGia", b =>
                {
                    b.Navigation("tapHopChiTietSach");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.TaiKhoanKhachHang", b =>
                {
                    b.Navigation("danhSachDonHang");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.TaiKhoanNhanVien", b =>
                {
                    b.Navigation("danhSachTrangThaiDonHang");
                });

            modelBuilder.Entity("WebsiteBanSach.Models.TrangThai", b =>
                {
                    b.Navigation("danhSachTrangThaiDonHang");
                });
#pragma warning restore 612, 618
        }
    }
}
