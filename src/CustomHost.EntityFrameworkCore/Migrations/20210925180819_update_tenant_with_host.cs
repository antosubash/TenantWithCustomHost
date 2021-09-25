using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomHost.Migrations
{
    public partial class update_tenant_with_host : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Host",
                table: "AbpTenants",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Host",
                table: "AbpTenants");
        }
    }
}
