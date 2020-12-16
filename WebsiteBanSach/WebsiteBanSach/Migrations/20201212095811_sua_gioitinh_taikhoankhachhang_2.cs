using Microsoft.EntityFrameworkCore.Migrations;

namespace WebsiteBanSach.Migrations
{
    public partial class sua_gioitinh_taikhoankhachhang_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gioiTinh",
                table: "TapHopTaiKhoanKhachHang",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gioiTinh",
                table: "TapHopTaiKhoanKhachHang");
        }
    }
}
