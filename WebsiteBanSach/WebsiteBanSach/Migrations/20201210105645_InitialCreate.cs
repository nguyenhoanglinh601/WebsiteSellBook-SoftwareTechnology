using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebsiteBanSach.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TapHopGiamGia",
                columns: table => new
                {
                    idGiamGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenChuongTrinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soTienGiam = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopGiamGia", x => x.idGiamGia);
                });

            migrationBuilder.CreateTable(
                name: "TapHopLoaiSach",
                columns: table => new
                {
                    idLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenLoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    moTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopLoaiSach", x => x.idLoai);
                });

            migrationBuilder.CreateTable(
                name: "TapHopNhaXuatBan",
                columns: table => new
                {
                    idNhaXuatBan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopNhaXuatBan", x => x.idNhaXuatBan);
                });

            migrationBuilder.CreateTable(
                name: "TapHopTacGia",
                columns: table => new
                {
                    idTacGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gioiTinh = table.Column<int>(type: "int", nullable: true),
                    namSinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quocTich = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopTacGia", x => x.idTacGia);
                });

            migrationBuilder.CreateTable(
                name: "TapHopTaiKhoanKhachHang",
                columns: table => new
                {
                    idKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gioiTinh = table.Column<int>(type: "int", nullable: false),
                    soDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diemMuaHang = table.Column<int>(type: "int", nullable: false),
                    taiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopTaiKhoanKhachHang", x => x.idKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "TapHopTaiKhoanNhanVien",
                columns: table => new
                {
                    idNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vaiTro = table.Column<int>(type: "int", nullable: true),
                    matKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopTaiKhoanNhanVien", x => x.idNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "TapHopTrangThai",
                columns: table => new
                {
                    idTrangThai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kieuTrangThai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopTrangThai", x => x.idTrangThai);
                });

            migrationBuilder.CreateTable(
                name: "TapHopSach",
                columns: table => new
                {
                    idSach = table.Column<int>(type: "int", nullable: false),
                    lanTaiBan = table.Column<int>(type: "int", nullable: false),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idNhaXuatBan = table.Column<int>(type: "int", nullable: false),
                    maLoai = table.Column<int>(type: "int", nullable: false),
                    giaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: false),
                    moTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<bool>(type: "bit", nullable: false),
                    nhaXuatBanidNhaXuatBan = table.Column<int>(type: "int", nullable: true),
                    loaiSachidLoai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopSach", x => new { x.idSach, x.lanTaiBan });
                    table.ForeignKey(
                        name: "FK_TapHopSach_TapHopLoaiSach_loaiSachidLoai",
                        column: x => x.loaiSachidLoai,
                        principalTable: "TapHopLoaiSach",
                        principalColumn: "idLoai",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TapHopSach_TapHopNhaXuatBan_nhaXuatBanidNhaXuatBan",
                        column: x => x.nhaXuatBanidNhaXuatBan,
                        principalTable: "TapHopNhaXuatBan",
                        principalColumn: "idNhaXuatBan",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TapHopDonHang",
                columns: table => new
                {
                    idDonHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idKhachHang = table.Column<int>(type: "int", nullable: false),
                    thoiGianDatHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    diaChiGiaoHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thoiGianGiaoHangDuKien = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phiGiaoHang = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    soDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    taiKhoanKhachHangidKhachHang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopDonHang", x => x.idDonHang);
                    table.ForeignKey(
                        name: "FK_TapHopDonHang_TapHopTaiKhoanKhachHang_taiKhoanKhachHangidKhachHang",
                        column: x => x.taiKhoanKhachHangidKhachHang,
                        principalTable: "TapHopTaiKhoanKhachHang",
                        principalColumn: "idKhachHang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TapHopChiTietSach",
                columns: table => new
                {
                    idSach = table.Column<int>(type: "int", nullable: false),
                    idTacGia = table.Column<int>(type: "int", nullable: false),
                    sachidSach = table.Column<int>(type: "int", nullable: true),
                    sachlanTaiBan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopChiTietSach", x => new { x.idSach, x.idTacGia });
                    table.ForeignKey(
                        name: "FK_TapHopChiTietSach_TapHopSach_sachidSach_sachlanTaiBan",
                        columns: x => new { x.sachidSach, x.sachlanTaiBan },
                        principalTable: "TapHopSach",
                        principalColumns: new[] { "idSach", "lanTaiBan" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TapHopChiTietSach_TapHopTacGia_idTacGia",
                        column: x => x.idTacGia,
                        principalTable: "TapHopTacGia",
                        principalColumn: "idTacGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TapHopChiTietDonHang",
                columns: table => new
                {
                    idDonHang = table.Column<int>(type: "int", nullable: false),
                    idSach = table.Column<int>(type: "int", nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: false),
                    sachidSach = table.Column<int>(type: "int", nullable: true),
                    sachlanTaiBan = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopChiTietDonHang", x => new { x.idDonHang, x.idSach });
                    table.ForeignKey(
                        name: "FK_TapHopChiTietDonHang_TapHopDonHang_idDonHang",
                        column: x => x.idDonHang,
                        principalTable: "TapHopDonHang",
                        principalColumn: "idDonHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TapHopChiTietDonHang_TapHopSach_sachidSach_sachlanTaiBan",
                        columns: x => new { x.sachidSach, x.sachlanTaiBan },
                        principalTable: "TapHopSach",
                        principalColumns: new[] { "idSach", "lanTaiBan" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TapHopChiTietGiamGia",
                columns: table => new
                {
                    idDonHang = table.Column<int>(type: "int", nullable: false),
                    idGiamGia = table.Column<int>(type: "int", nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopChiTietGiamGia", x => new { x.idDonHang, x.idGiamGia });
                    table.ForeignKey(
                        name: "FK_TapHopChiTietGiamGia_TapHopDonHang_idDonHang",
                        column: x => x.idDonHang,
                        principalTable: "TapHopDonHang",
                        principalColumn: "idDonHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TapHopChiTietGiamGia_TapHopGiamGia_idGiamGia",
                        column: x => x.idGiamGia,
                        principalTable: "TapHopGiamGia",
                        principalColumn: "idGiamGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TapHopTrangThaiDonHang",
                columns: table => new
                {
                    idDonHang = table.Column<int>(type: "int", nullable: false),
                    idTrangThai = table.Column<int>(type: "int", nullable: false),
                    idNhanVien = table.Column<int>(type: "int", nullable: false),
                    thoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    donHangidDonHang = table.Column<int>(type: "int", nullable: true),
                    trangThaiidTrangThai = table.Column<int>(type: "int", nullable: true),
                    taiKhoanNhanVienidNhanVien = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TapHopTrangThaiDonHang", x => new { x.idDonHang, x.idTrangThai });
                    table.ForeignKey(
                        name: "FK_TapHopTrangThaiDonHang_TapHopDonHang_donHangidDonHang",
                        column: x => x.donHangidDonHang,
                        principalTable: "TapHopDonHang",
                        principalColumn: "idDonHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TapHopTrangThaiDonHang_TapHopTaiKhoanNhanVien_taiKhoanNhanVienidNhanVien",
                        column: x => x.taiKhoanNhanVienidNhanVien,
                        principalTable: "TapHopTaiKhoanNhanVien",
                        principalColumn: "idNhanVien",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TapHopTrangThaiDonHang_TapHopTrangThai_trangThaiidTrangThai",
                        column: x => x.trangThaiidTrangThai,
                        principalTable: "TapHopTrangThai",
                        principalColumn: "idTrangThai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TapHopChiTietDonHang_sachidSach_sachlanTaiBan",
                table: "TapHopChiTietDonHang",
                columns: new[] { "sachidSach", "sachlanTaiBan" });

            migrationBuilder.CreateIndex(
                name: "IX_TapHopChiTietGiamGia_idGiamGia",
                table: "TapHopChiTietGiamGia",
                column: "idGiamGia");

            migrationBuilder.CreateIndex(
                name: "IX_TapHopChiTietSach_idTacGia",
                table: "TapHopChiTietSach",
                column: "idTacGia");

            migrationBuilder.CreateIndex(
                name: "IX_TapHopChiTietSach_sachidSach_sachlanTaiBan",
                table: "TapHopChiTietSach",
                columns: new[] { "sachidSach", "sachlanTaiBan" });

            migrationBuilder.CreateIndex(
                name: "IX_TapHopDonHang_taiKhoanKhachHangidKhachHang",
                table: "TapHopDonHang",
                column: "taiKhoanKhachHangidKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_TapHopSach_loaiSachidLoai",
                table: "TapHopSach",
                column: "loaiSachidLoai");

            migrationBuilder.CreateIndex(
                name: "IX_TapHopSach_nhaXuatBanidNhaXuatBan",
                table: "TapHopSach",
                column: "nhaXuatBanidNhaXuatBan");

            migrationBuilder.CreateIndex(
                name: "IX_TapHopTrangThaiDonHang_donHangidDonHang",
                table: "TapHopTrangThaiDonHang",
                column: "donHangidDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_TapHopTrangThaiDonHang_taiKhoanNhanVienidNhanVien",
                table: "TapHopTrangThaiDonHang",
                column: "taiKhoanNhanVienidNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_TapHopTrangThaiDonHang_trangThaiidTrangThai",
                table: "TapHopTrangThaiDonHang",
                column: "trangThaiidTrangThai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TapHopChiTietDonHang");

            migrationBuilder.DropTable(
                name: "TapHopChiTietGiamGia");

            migrationBuilder.DropTable(
                name: "TapHopChiTietSach");

            migrationBuilder.DropTable(
                name: "TapHopTrangThaiDonHang");

            migrationBuilder.DropTable(
                name: "TapHopGiamGia");

            migrationBuilder.DropTable(
                name: "TapHopSach");

            migrationBuilder.DropTable(
                name: "TapHopTacGia");

            migrationBuilder.DropTable(
                name: "TapHopDonHang");

            migrationBuilder.DropTable(
                name: "TapHopTaiKhoanNhanVien");

            migrationBuilder.DropTable(
                name: "TapHopTrangThai");

            migrationBuilder.DropTable(
                name: "TapHopLoaiSach");

            migrationBuilder.DropTable(
                name: "TapHopNhaXuatBan");

            migrationBuilder.DropTable(
                name: "TapHopTaiKhoanKhachHang");
        }
    }
}
