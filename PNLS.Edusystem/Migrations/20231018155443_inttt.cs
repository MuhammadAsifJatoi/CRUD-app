using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PNLS.Edusystem.Migrations
{
    public partial class inttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_studentsTable",
                table: "studentsTable");

            migrationBuilder.RenameTable(
                name: "studentsTable",
                newName: "StudentsRecod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentsRecod",
                table: "StudentsRecod",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentsRecod",
                table: "StudentsRecod");

            migrationBuilder.RenameTable(
                name: "StudentsRecod",
                newName: "studentsTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentsTable",
                table: "studentsTable",
                column: "Id");
        }
    }
}
