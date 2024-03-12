using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class studentLessonCrossTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentLesson",
                columns: table => new
                {
                    SId = table.Column<int>(type: "integer", nullable: false),
                    LId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLesson", x => new { x.SId, x.LId });
                    table.ForeignKey(
                        name: "FK_StudentLesson_Lessons_LId",
                        column: x => x.LId,
                        principalTable: "Lessons",
                        principalColumn: "lessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentLesson_Students_SId",
                        column: x => x.SId,
                        principalTable: "Students",
                        principalColumn: "SudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentLesson_LId",
                table: "StudentLesson",
                column: "LId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentLesson");
        }
    }
}
