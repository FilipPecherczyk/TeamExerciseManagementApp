using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamExerciseManagementApp.Migrations
{
    /// <inheritdoc />
    public partial class DataBaseCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Results_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    BenchPress = table.Column<int>(type: "int", nullable: false),
                    Squats = table.Column<int>(type: "int", nullable: false),
                    Deadlift = table.Column<int>(type: "int", nullable: false),
                    Run60 = table.Column<int>(type: "int", nullable: false),
                    Jump = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Results_ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCategory = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Results_ID1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_Users_Results_Results_ID1",
                        column: x => x.Results_ID1,
                        principalTable: "Results",
                        principalColumn: "Results_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Results_ID1",
                table: "Users",
                column: "Results_ID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Results");
        }
    }
}
