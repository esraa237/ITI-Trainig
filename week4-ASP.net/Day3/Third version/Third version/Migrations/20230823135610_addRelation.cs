using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Third_version.Migrations
{
    public partial class addRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptNum",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeptName",
                table: "Departments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeptNum",
                table: "Students",
                column: "DeptNum");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DeptNum",
                table: "Students",
                column: "DeptNum",
                principalTable: "Departments",
                principalColumn: "DeptId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DeptNum",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DeptNum",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeptNum",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "DeptName",
                table: "Departments",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);
        }
    }
}
