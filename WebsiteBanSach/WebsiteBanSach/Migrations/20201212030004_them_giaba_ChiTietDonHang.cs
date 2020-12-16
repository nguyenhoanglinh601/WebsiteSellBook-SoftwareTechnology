using Microsoft.EntityFrameworkCore.Migrations;

namespace WebsiteBanSach.Migrations
{
    public partial class them_giaba_ChiTietDonHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "giaBan",
                table: "TapHopChiTietDonHang",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "giaBan",
                table: "TapHopChiTietDonHang");
        }
    }
}
