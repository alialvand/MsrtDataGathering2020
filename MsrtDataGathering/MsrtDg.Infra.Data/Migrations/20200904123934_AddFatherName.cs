using Microsoft.EntityFrameworkCore.Migrations;

namespace MsrtDg.Infra.Data.Migrations
{
    public partial class AddFatherName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Persons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Persons");
        }
    }
}
