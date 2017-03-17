using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NewResume.Data.Migrations
{
    public partial class jobduties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "JobDuty",
                columns: table => new
                {
                    JobDutyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Duty = table.Column<string>(maxLength: 5000, nullable: true),
                    JobId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobDuty", x => x.JobDutyId);
                    table.ForeignKey(
                        name: "FK_JobDuty_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobDuty_JobId",
                table: "JobDuty",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobDuty");

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
    }
}
