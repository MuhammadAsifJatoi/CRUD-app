using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PNLS.Edusystem.Migrations
{
    public partial class codeDbpnls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adMinsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(30)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(30)", nullable: false),
                    Password = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adMinsTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "studentsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    fatherName = table.Column<string>(type: "varchar(20)", nullable: false),
                    Gender = table.Column<string>(type: "varchar(8)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<string>(type: "varchar(20)", nullable: false),
                    Deparment = table.Column<string>(type: "varchar(20)", nullable: false),
                    Mobile = table.Column<string>(type: "varchar(13)", nullable: false),
                    Adress = table.Column<string>(type: "varchar(100)", nullable: false),
                    City = table.Column<string>(type: "varchar(30)", nullable: false),
                    Distrit = table.Column<string>(type: "varchar(50)", nullable: false),
                    provence = table.Column<string>(type: "varchar(50)", nullable: false),
                    Country = table.Column<string>(type: "varchar(50)", nullable: false),
                    fee = table.Column<int>(type: "int", nullable: false),
                    Joindate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentsTable", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "adMinsTable");

            migrationBuilder.DropTable(
                name: "studentsTable");
        }
    }
}
