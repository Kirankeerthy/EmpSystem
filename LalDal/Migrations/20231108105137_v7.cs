using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabDal.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ManyCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManyCourses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToManyStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToManyStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OneStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManyCourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OneStudents_ManyCourses_ManyCourseId",
                        column: x => x.ManyCourseId,
                        principalTable: "ManyCourses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OneCourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToManyStudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OneCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OneCourses_ToManyStudents_ToManyStudentId",
                        column: x => x.ToManyStudentId,
                        principalTable: "ToManyStudents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ToOneCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatedToOneStudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToOneCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToOneCompanies_OneStudents_RelatedToOneStudentId",
                        column: x => x.RelatedToOneStudentId,
                        principalTable: "OneStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OneCourses_ToManyStudentId",
                table: "OneCourses",
                column: "ToManyStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_OneStudents_ManyCourseId",
                table: "OneStudents",
                column: "ManyCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ToOneCompanies_RelatedToOneStudentId",
                table: "ToOneCompanies",
                column: "RelatedToOneStudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OneCourses");

            migrationBuilder.DropTable(
                name: "ToOneCompanies");

            migrationBuilder.DropTable(
                name: "ToManyStudents");

            migrationBuilder.DropTable(
                name: "OneStudents");

            migrationBuilder.DropTable(
                name: "ManyCourses");
        }
    }
}
