using Microsoft.EntityFrameworkCore.Migrations;

namespace HRIS_Application.Migrations.Employee
{
    public partial class CreateEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeTbl",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    EmpCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    BranchLocation = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTbl", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTbl");
        }
    }
}
