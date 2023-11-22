using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestDal.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ToMany1Id",
                table: "Ones",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ToMany1s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToMany1s", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ones_ToMany1Id",
                table: "Ones",
                column: "ToMany1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ones_ToMany1s_ToMany1Id",
                table: "Ones",
                column: "ToMany1Id",
                principalTable: "ToMany1s",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ones_ToMany1s_ToMany1Id",
                table: "Ones");

            migrationBuilder.DropTable(
                name: "ToMany1s");

            migrationBuilder.DropIndex(
                name: "IX_Ones_ToMany1Id",
                table: "Ones");

            migrationBuilder.DropColumn(
                name: "ToMany1Id",
                table: "Ones");
        }
    }
}
