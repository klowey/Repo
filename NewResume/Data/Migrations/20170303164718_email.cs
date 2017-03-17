using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewResume.Data.Migrations
{
    public partial class email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ContactInfo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "ContactInfo",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "ContactInfo");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "ContactInfo");
        }
    }
}
