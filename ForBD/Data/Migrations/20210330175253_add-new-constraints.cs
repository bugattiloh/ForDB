using Microsoft.EntityFrameworkCore.Migrations;

namespace ForBD.Data.Migrations
{
    public partial class addnewconstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plans_Typographies_TypographyId",
                table: "Plans");

            migrationBuilder.DropTable(
                name: "Typographies");

            migrationBuilder.DropTable(
                name: "Accountings");

            migrationBuilder.DropIndex(
                name: "IX_Plans_TypographyId",
                table: "Plans");

            migrationBuilder.DropColumn(
                name: "TypographyId",
                table: "Plans");

            migrationBuilder.CreateTable(
                name: "MaterialPlan",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialPlan", x => new { x.PlanId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_MaterialPlan_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialPlan_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialPlan_MaterialId",
                table: "MaterialPlan",
                column: "MaterialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialPlan");

            migrationBuilder.AddColumn<int>(
                name: "TypographyId",
                table: "Plans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Accountings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InDepartment = table.Column<int>(type: "int", nullable: false),
                    InLibrary = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    TypographyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accountings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accountings_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Typographies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountingId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Stage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Typographies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Typographies_Accountings_AccountingId",
                        column: x => x.AccountingId,
                        principalTable: "Accountings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plans_TypographyId",
                table: "Plans",
                column: "TypographyId");

            migrationBuilder.CreateIndex(
                name: "IX_Accountings_MaterialId",
                table: "Accountings",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Typographies_AccountingId",
                table: "Typographies",
                column: "AccountingId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Plans_Typographies_TypographyId",
                table: "Plans",
                column: "TypographyId",
                principalTable: "Typographies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
