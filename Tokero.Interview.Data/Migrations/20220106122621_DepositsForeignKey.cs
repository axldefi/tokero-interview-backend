using Microsoft.EntityFrameworkCore.Migrations;

namespace Tokero.Interview.Data.Migrations
{
    public partial class DepositsForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Deposits_OperationId",
                table: "Deposits",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deposits_Operations_OperationId",
                table: "Deposits",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deposits_Operations_OperationId",
                table: "Deposits");

            migrationBuilder.DropIndex(
                name: "IX_Deposits_OperationId",
                table: "Deposits");
        }
    }
}
