using Microsoft.EntityFrameworkCore.Migrations;

namespace WebsiteBanSach.Migrations
{
    public partial class sua_vaitro_taikhoannhanvien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "vaiTro",
                table: "TapHopTaiKhoanNhanVien",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "vaiTro",
                table: "TapHopTaiKhoanNhanVien",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
