using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PNLS.Edusystem.Migrations
{
    public partial class initwork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "doctertable",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctertable", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doctertable");

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
    }
}
