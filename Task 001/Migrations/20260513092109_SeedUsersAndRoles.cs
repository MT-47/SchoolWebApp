using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Task_001.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "u1", 0, "u1", "aly@iti.gov", false, false, null, "ALY@ITI.GOV", "ALY@ITI.GOV", "AQAAAAIAAYagAAAAEAgm9vKdxI5Pe9ZxW8psE/NeWl3ApJABFqRiI5DVsWf9bxcp2/qDGzektXxaep7vrQ==", null, false, "u1", 1, false, "aly@iti.gov" },
                    { "u10", 0, "u10", "mt@m.com", false, false, null, "MT@M.COM", "MT@M.COM", "AQAAAAIAAYagAAAAEO/al6JELwywL5gSL7YmzdQzEbnRLoSK13Ex5k/vJfq8GAKs+Oj7Gefrk1sD5SoARQ==", null, false, "u10", 10, false, "mt@m.com" },
                    { "u11", 0, "u11", "b@mail.com", false, false, null, "B@MAIL.COM", "B@MAIL.COM", "AQAAAAIAAYagAAAAEGJpO69yYNQPWKxDkfuU+5jYyNopK15OMDRQrc0ZUUWQVKfh7+Y6KSPmY0GSSX3dog==", null, false, "u11", 11, false, "b@mail.com" },
                    { "u13", 0, "u13", "A@B.C", false, false, null, "A@B.C", "A@B.C", "AQAAAAIAAYagAAAAEDNvC6qhVVMA8ux0AD+dQ6UFUW43fCXvDD2y3aviRd6oIW0/HNMinPoG6diS/w7rfw==", null, false, "u13", 13, false, "A@B.C" },
                    { "u2", 0, "u2", "sara@iti.gov", false, false, null, "SARA@ITI.GOV", "SARA@ITI.GOV", "AQAAAAIAAYagAAAAEDKX8wZgqbu2M8XB0kDqfRMvQpOj1B2XWzk3oljsv1soKtfIMxQK4b2nDuLlap3KDA==", null, false, "u2", 2, false, "sara@iti.gov" },
                    { "u3", 0, "u3", "ahmed@iti.gov", false, false, null, "AHMED@ITI.GOV", "AHMED@ITI.GOV", "AQAAAAIAAYagAAAAENHAHzMxcyGsr1nYaKN70vdRdPY3tMiCNMMpKiiPW/28eO2vMoeHjW7UDFmYYfIsww==", null, false, "u3", 3, false, "ahmed@iti.gov" },
                    { "u8", 0, "u8", "khaled@iti.gov", false, false, null, "KHALED@ITI.GOV", "KHALED@ITI.GOV", "AQAAAAIAAYagAAAAECpzYQybWfeWinat8NtDchhY7UzEw/MdHDrDMZW4DjABr6WMQqvhuaPoEQ61jBivJQ==", null, false, "u8", 8, false, "khaled@iti.gov" },
                    { "u9", 0, "u9", "metwally@iti.gov", false, false, null, "METWALLY@ITI.GOV", "METWALLY@ITI.GOV", "AQAAAAIAAYagAAAAEC8/UKja4i8wxehs9WfSuz3AqsRPTewzScWsJyFENqEoMCr2eOWSC3g5ptEIuBiN5Q==", null, false, "u9", 9, false, "metwally@iti.gov" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "u1" },
                    { "2", "u10" },
                    { "2", "u11" },
                    { "2", "u13" },
                    { "2", "u2" },
                    { "2", "u3" },
                    { "2", "u8" },
                    { "2", "u9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "u1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "u10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "u11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "u13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "u2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "u3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "u8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "u9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u9");
        }
    }
}
