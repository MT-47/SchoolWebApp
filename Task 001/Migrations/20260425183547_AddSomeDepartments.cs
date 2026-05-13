using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Task_001.Migrations
{
    /// <inheritdoc />
    public partial class AddSomeDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_MgrId",
                table: "Departments");

            migrationBuilder.AlterColumn<int>(
                name: "MgrId",
                table: "Departments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DeptId", "Capacity", "MgrId", "Name" },
                values: new object[,]
                {
                    { 100, 50, null, ".net" },
                    { 200, 30, null, "pd" },
                    { 300, 25, null, "os" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MgrId",
                table: "Departments",
                column: "MgrId",
                unique: true,
                filter: "[MgrId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Departments_MgrId",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 300);

            migrationBuilder.AlterColumn<int>(
                name: "MgrId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_MgrId",
                table: "Departments",
                column: "MgrId",
                unique: true);
        }
    }
}
