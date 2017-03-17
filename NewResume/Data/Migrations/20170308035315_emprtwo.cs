using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewResume.Data.Migrations
{
    public partial class emprtwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployerId",
                table: "Job",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Job_EmployerId",
                table: "Job",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_Employer_EmployerId",
                table: "Job",
                column: "EmployerId",
                principalTable: "Employer",
                principalColumn: "EmployerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_Employer_EmployerId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_EmployerId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "EmployerId",
                table: "Job");
        }
    }
}
