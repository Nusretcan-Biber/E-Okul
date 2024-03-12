using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class noteAndStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Notes_StudentId",
                table: "Notes",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Students_StudentId",
                table: "Notes",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "SudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Students_StudentId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_StudentId",
                table: "Notes");
        }
    }
}
