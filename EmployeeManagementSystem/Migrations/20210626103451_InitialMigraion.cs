using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagementSystem.Migrations
{
    public partial class InitialMigraion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Department = table.Column<string>(maxLength: 50, nullable: false),
                    WorkLocation = table.Column<string>(maxLength: 50, nullable: true),
                    TechnologyStack = table.Column<string>(maxLength: 50, nullable: true),
                    DateOfJoining = table.Column<DateTime>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    CTC = table.Column<int>(nullable: false),
                    BaseSalary = table.Column<int>(nullable: false),
                    ManagerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
