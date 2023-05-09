using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Projekt___Avancerad_.NET_Team_Super_Ninjas.Migrations
{
    /// <inheritdoc />
    public partial class initcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "TimeReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkHours = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeReports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => new { x.ProjectId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "Kalle@företaget.com", "Kalle Gustavsson" },
                    { 2, "Sara@företaget.com", "Sara Andersson" },
                    { 3, "Johan@företaget.com", "Johan Svensson" },
                    { 4, "Lisa@företaget.com", "Lisa Lindström" },
                    { 5, "Anders@företaget.com", "Anders Nilsson" },
                    { 6, "Emma@företaget.com", "Emma Bergström" },
                    { 7, "Peter@företaget.com", "Peter Persson" },
                    { 8, "Maria@företaget.com", "Maria Karlsson" },
                    { 9, "Erik@företaget.com", "Erik Johansson" },
                    { 10, "Anna@företaget.com", "Anna Ahlström" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Develop an online store for a retail company.", "E-commerce Website" },
                    { 2, "Create a web platform for bloggers to publish and share their content.", "Blog Platform" },
                    { 3, "Develop a fun and engaging mobile game for iOS and Android platforms.", "Mobile Game App" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjects",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 10, 2 },
                    { 4, 3 },
                    { 5, 3 },
                    { 9, 3 },
                    { 10, 3 }
                });

            migrationBuilder.InsertData(
                table: "TimeReports",
                columns: new[] { "Id", "EmployeeId", "End", "Start", "WorkHours" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0) },
                    { 2, 2, new DateTime(2023, 3, 15, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 30, 0, 0) },
                    { 3, 3, new DateTime(2023, 4, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 4, 4, new DateTime(2023, 5, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0) },
                    { 5, 5, new DateTime(2023, 1, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0) },
                    { 6, 6, new DateTime(2023, 2, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 7, 7, new DateTime(2023, 3, 22, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 8, 8, new DateTime(2023, 4, 14, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 14, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 9, 9, new DateTime(2023, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 10, 10, new DateTime(2023, 1, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 11, 1, new DateTime(2023, 1, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0) },
                    { 12, 1, new DateTime(2023, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 13, 2, new DateTime(2023, 1, 2, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 14, 3, new DateTime(2023, 1, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 15, 4, new DateTime(2023, 1, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 16, 5, new DateTime(2023, 1, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 17, 6, new DateTime(2023, 1, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 6, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 18, 7, new DateTime(2023, 1, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 19, 8, new DateTime(2023, 1, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 20, 9, new DateTime(2023, 1, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 21, 1, new DateTime(2023, 3, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 22, 2, new DateTime(2023, 4, 18, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 18, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0) },
                    { 23, 3, new DateTime(2023, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 24, 4, new DateTime(2023, 1, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 25, 5, new DateTime(2023, 2, 10, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) },
                    { 26, 6, new DateTime(2023, 3, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0) },
                    { 27, 7, new DateTime(2023, 4, 10, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 14, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0) },
                    { 28, 8, new DateTime(2023, 5, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 30, 0, 0) },
                    { 29, 9, new DateTime(2023, 1, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 13, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0) },
                    { 30, 10, new DateTime(2023, 2, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_EmployeeId",
                table: "EmployeeProjects",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeReports_EmployeeId",
                table: "TimeReports",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.DropTable(
                name: "TimeReports");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
