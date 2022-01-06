using Microsoft.EntityFrameworkCore.Migrations;

namespace Tokero.Interview.Data.Migrations
{
    public partial class OperationsForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Operations_OperationTypeId",
                table: "Operations",
                column: "OperationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_OperationTypes_OperationTypeId",
                table: "Operations",
                column: "OperationTypeId",
                principalTable: "OperationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operations_OperationTypes_OperationTypeId",
                table: "Operations");

            migrationBuilder.DropIndex(
                name: "IX_Operations_OperationTypeId",
                table: "Operations");
        }
    }
}
