using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NewResume.Data.Migrations
{
    public partial class employerjobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployerJobViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployerJobViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployerJobViewModel_Employer_EmployerId",
                        column: x => x.EmployerId,
                        principalTable: "Employer",
                        principalColumn: "EmployerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddColumn<int>(
                name: "EmployerJobViewModelId",
                table: "Job",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Job_EmployerJobViewModelId",
                table: "Job",
                column: "EmployerJobViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployerJobViewModel_EmployerId",
                table: "EmployerJobViewModel",
                column: "EmployerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Job_EmployerJobViewModel_EmployerJobViewModelId",
                table: "Job",
                column: "EmployerJobViewModelId",
                principalTable: "EmployerJobViewModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Job_EmployerJobViewModel_EmployerJobViewModelId",
                table: "Job");

            migrationBuilder.DropIndex(
                name: "IX_Job_EmployerJobViewModelId",
                table: "Job");

            migrationBuilder.DropColumn(
                name: "EmployerJobViewModelId",
                table: "Job");

            migrationBuilder.DropTable(
                name: "EmployerJobViewModel");
        }
    }
}
