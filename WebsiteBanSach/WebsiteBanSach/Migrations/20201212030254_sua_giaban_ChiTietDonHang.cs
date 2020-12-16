using Microsoft.EntityFrameworkCore.Migrations;

namespace WebsiteBanSach.Migrations
{
    public partial class sua_giaban_ChiTietDonHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "giaBan",
                table: "TapHopChiTietDonHang",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "giaBan",
                table: "TapHopChiTietDonHang",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
