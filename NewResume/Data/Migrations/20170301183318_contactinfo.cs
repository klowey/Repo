using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NewResume.Data.Migrations
{
    public partial class contactinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ContactInfo");

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    JobId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JobDateFrom = table.Column<DateTime>(nullable: false),
                    JobDateTo = table.Column<DateTime>(nullable: false),
                    JobTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.JobId);
                });

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ContactInfo",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "ContactInfo",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ContactInfo");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "ContactInfo");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ContactInfo",
                nullable: false,
                defaultValue: "");
        }
    }
}
