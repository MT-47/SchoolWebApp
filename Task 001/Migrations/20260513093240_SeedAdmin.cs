using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_001.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEPX/+Itfr7f28E0rE46uplKXfrF/w1MwFII5XTV2PKBnOnPa0fSUPYgW7am6UYfH4g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u10",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ7pc7hcLrgsPzo0hyXj++X8mTnLo3S5hqSFCwYZFdXxgd85atPyo9ilfyhxUBk7GA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u11",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEG+eBN7LY4l2uSlM9t04neotxO2385FAw+jLBO4JrDpC6LbbMe/aTyejlgzIosjQzQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u13",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEK11372VytI7jUUSkDHEg7LZg5y23Ipnq+t5wPKuScTobl/jwfB4PqfmHrWVs6XEmA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u2",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKDJ3UhAUgi7RlN3iX1EaRHorkreoReUmCz7o0mFr5DbUWD3D+iJOz9oVk8aPx5Udw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJVFYW5pyhPLgYMsgxkj4L3ibWlKCB9O7B7AagQ6bchMRKPspJTFRSA6ZCP3P3PgCw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u8",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEM0RXaTqEKC//rNjU5lYKu/gsFhqlzpfhfZvVeunCKfN9krf48oa4Awav7OIPGUNVA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEBKbQxUn5ynDep4e3KG5l5EVGYLjtHfbx5PWB3GtyrcdQ6jvGHs2pPBiEth+Oa+zHg==");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "admin1", 0, "admin1", "admin@iti.gov", false, false, null, "ADMIN@ITI.GOV", "ADMIN@ITI.GOV", "AQAAAAIAAYagAAAAEMxt0rKT8t5A2Lwicj0cRILRlTH/q2YoJZjgpxAq1L3SzSccbBmNhn20IZOkjjy/IA==", null, false, "admin1", null, false, "admin@iti.gov" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "admin1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "admin1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u1",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAgm9vKdxI5Pe9ZxW8psE/NeWl3ApJABFqRiI5DVsWf9bxcp2/qDGzektXxaep7vrQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u10",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEO/al6JELwywL5gSL7YmzdQzEbnRLoSK13Ex5k/vJfq8GAKs+Oj7Gefrk1sD5SoARQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u11",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGJpO69yYNQPWKxDkfuU+5jYyNopK15OMDRQrc0ZUUWQVKfh7+Y6KSPmY0GSSX3dog==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u13",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDNvC6qhVVMA8ux0AD+dQ6UFUW43fCXvDD2y3aviRd6oIW0/HNMinPoG6diS/w7rfw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u2",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEDKX8wZgqbu2M8XB0kDqfRMvQpOj1B2XWzk3oljsv1soKtfIMxQK4b2nDuLlap3KDA==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u3",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENHAHzMxcyGsr1nYaKN70vdRdPY3tMiCNMMpKiiPW/28eO2vMoeHjW7UDFmYYfIsww==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u8",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAECpzYQybWfeWinat8NtDchhY7UzEw/MdHDrDMZW4DjABr6WMQqvhuaPoEQ61jBivJQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u9",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEC8/UKja4i8wxehs9WfSuz3AqsRPTewzScWsJyFENqEoMCr2eOWSC3g5ptEIuBiN5Q==");
        }
    }
}
