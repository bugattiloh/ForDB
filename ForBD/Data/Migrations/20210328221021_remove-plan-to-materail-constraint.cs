using Microsoft.EntityFrameworkCore.Migrations;

namespace ForBD.Data.Migrations
{
    public partial class removeplantomaterailconstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plans_Materials_MaterialId",
                table: "Plans");

            migrationBuilder.DropIndex(
                name: "IX_Plans_MaterialId",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "MaterialId",
                table: "Plans");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaterialId",
                table: "Plans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Plans_MaterialId",
                table: "Plans",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plans_Materials_MaterialId",
                table: "Plans",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
