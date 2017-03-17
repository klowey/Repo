using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewResume.Data.Migrations
{
    public partial class referencestwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Reference");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Reference");

            migrationBuilder.AddColumn<string>(
                name: "RefFirstName",
                table: "Reference",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefLastName",
                table: "Reference",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefFirstName",
                table: "Reference");

            migrationBuilder.DropColumn(
                name: "RefLastName",
                table: "Reference");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Reference",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Reference",
                nullable: false,
                defaultValue: "");
        }
    }
}
