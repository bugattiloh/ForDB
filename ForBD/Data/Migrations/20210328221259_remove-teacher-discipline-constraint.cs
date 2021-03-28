using Microsoft.EntityFrameworkCore.Migrations;

namespace ForBD.Data.Migrations
{
    public partial class removeteacherdisciplineconstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Disciplines_DisciplineId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_DisciplineId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DisciplineId",
                table: "Teachers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisciplineId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_DisciplineId",
                table: "Teachers",
                column: "DisciplineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Disciplines_DisciplineId",
                table: "Teachers",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
