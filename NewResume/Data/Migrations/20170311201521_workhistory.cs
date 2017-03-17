using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewResume.Data.Migrations
{
    public partial class workhistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkHistoryJobId",
                table: "Employer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employer_WorkHistoryJobId",
                table: "Employer",
                column: "WorkHistoryJobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employer_Job_WorkHistoryJobId",
                table: "Employer",
                column: "WorkHistoryJobId",
                principalTable: "Job",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employer_Job_WorkHistoryJobId",
                table: "Employer");

            migrationBuilder.DropIndex(
                name: "IX_Employer_WorkHistoryJobId",
                table: "Employer");

            migrationBuilder.DropColumn(
                name: "WorkHistoryJobId",
                table: "Employer");
        }
    }
}
