using Microsoft.EntityFrameworkCore.Migrations;

namespace AsrSystem.Data.Migrations
{
    public partial class AddStudentUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StudentID",
                table: "AspNetUsers",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Student_StudentID",
                table: "AspNetUsers",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Student_StudentID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StudentID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
