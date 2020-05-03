using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS_Application.Migrations.Company
{
    public partial class AddCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyTbl",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    CompanyCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    CompanyType = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTbl", x => x.CompanyId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyTbl");
        }
    }
}
