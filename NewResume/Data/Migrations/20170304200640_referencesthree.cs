using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewResume.Data.Migrations
{
    public partial class referencesthree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Reference");

            migrationBuilder.AddColumn<string>(
                name: "RefEmail",
                table: "Reference",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefEmail",
                table: "Reference");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Reference",
                nullable: true);
        }
    }
}
