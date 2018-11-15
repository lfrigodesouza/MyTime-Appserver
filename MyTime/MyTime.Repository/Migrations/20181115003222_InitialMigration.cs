using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTime.Repository.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBLUser",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(25)", nullable: false),
                    Code = table.Column<string>(type: "varchar(10)", nullable: false),
                    Password = table.Column<string>(type: "varchar(256)", nullable: false),
                    FlgEnable = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    UserType = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLUser", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "TBLTask",
                columns: table => new
                {
                    IdTask = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(10)", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    TotalDuration = table.Column<decimal>(type: "decimal", nullable: false, defaultValue: 0m),
                    TaskStatus = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DtCreation = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "NOW()"),
                    DtStarted = table.Column<DateTime>(type: "datetime", nullable: true),
                    DtFinished = table.Column<DateTime>(type: "datetime", nullable: true),
                    IdUser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLTask", x => x.IdTask);
                    table.ForeignKey(
                        name: "FK_TBLTask_TBLUser_IdUser",
                        column: x => x.IdUser,
                        principalTable: "TBLUser",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBLAppointment",
                columns: table => new
                {
                    IdAppointment = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DtStart = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "NOW()"),
                    DtEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    FlgDeleted = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IdTask = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBLAppointment", x => x.IdAppointment);
                    table.ForeignKey(
                        name: "FK_TBLAppointment_TBLTask_IdTask",
                        column: x => x.IdTask,
                        principalTable: "TBLTask",
                        principalColumn: "IdTask",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBLAppointment_IdTask",
                table: "TBLAppointment",
                column: "IdTask");

            migrationBuilder.CreateIndex(
                name: "IX_TBLTask_IdUser",
                table: "TBLTask",
                column: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBLAppointment");

            migrationBuilder.DropTable(
                name: "TBLTask");

            migrationBuilder.DropTable(
                name: "TBLUser");
        }
    }
}
