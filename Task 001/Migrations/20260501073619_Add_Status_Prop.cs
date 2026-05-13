using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_001.Migrations
{
    /// <inheritdoc />
    public partial class Add_Status_Prop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 100,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 200,
                column: "Status",
                value: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 300,
                column: "Status",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Departments");
        }
    }
}
