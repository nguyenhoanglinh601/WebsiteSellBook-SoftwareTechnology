using Microsoft.EntityFrameworkCore.Migrations;

namespace WebsiteBanSach.Migrations
{
    public partial class sua_gioitinh_taikhoankhachhang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gioiTinh",
                table: "TapHopTaiKhoanKhachHang");

            migrationBuilder.AlterColumn<string>(
                name: "tenKhachHang",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "taiKhoan",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "soDienThoai",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "matKhau",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "diaChi",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "tenKhachHang",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "taiKhoan",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "soDienThoai",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "matKhau",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "diaChi",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "gioiTinh",
                table: "TapHopTaiKhoanKhachHang",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
