using Microsoft.EntityFrameworkCore.Migrations;

namespace Tokero.Interview.Data.Migrations
{
    public partial class DepositsForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Withdrawals_OperationId",
                table: "Withdrawals",
                column: "OperationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Withdrawals_Operations_OperationId",
                table: "Withdrawals",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Withdrawals_Operations_OperationId",
                table: "Withdrawals");

            migrationBuilder.DropIndex(
                name: "IX_Withdrawals_OperationId",
                table: "Withdrawals");
        }
    }
}
