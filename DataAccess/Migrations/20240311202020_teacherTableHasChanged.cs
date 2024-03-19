using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class teacherTableHasChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "teacherFullName",
                table: "Teachers",
                newName: "teacherSurname");

            migrationBuilder.AddColumn<string>(
                name: "teacherName",
                table: "Teachers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "teacherName",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "teacherSurname",
                table: "Teachers",
                newName: "teacherFullName");
        }
    }
}
