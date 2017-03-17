using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewResume.Data.Migrations
{
    public partial class jobdutytwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployerJobViewModelId",
                table: "JobDuty",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobDuty_EmployerJobViewModelId",
                table: "JobDuty",
                column: "EmployerJobViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobDuty_EmployerJobViewModel_EmployerJobViewModelId",
                table: "JobDuty",
                column: "EmployerJobViewModelId",
                principalTable: "EmployerJobViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobDuty_EmployerJobViewModel_EmployerJobViewModelId",
                table: "JobDuty");

            migrationBuilder.DropIndex(
                name: "IX_JobDuty_EmployerJobViewModelId",
                table: "JobDuty");

            migrationBuilder.DropColumn(
                name: "EmployerJobViewModelId",
                table: "JobDuty");
        }
    }
}
