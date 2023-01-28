using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoreMVCpetproject.Data.Migrations
{
    /// <inheritdoc />
    public partial class BaseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f43a5f7-5d55-40a2-12ac-2c8b0c8b0c8b", null, "User", "USER" },
                    { "5f43a8f9-5d86-40a2-81ac-2c8b0c8b0c8b", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5f55a8f9-5d86-40a2-81ac-2c8b0c8b0c8b", 0, "f1597f3a-5c84-46d6-86d8-c5929c85fa21", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Ralf", "Kurz", false, null, "user@GMAIL.COM", "user@GMAIL.COM", "AQAAAAIAAYagAAAAEEzEBbeInQ13zBuk4oEwQdiR84L/eHTWuEt1pOiiAlCvgwlg1y8Q3DhyhRXT3SogCw==", null, false, "3c23d865-feac-4226-b93f-c2c11868d633", null, false, "user@gmail.com" },
                    { "5f55a8f9-5d86-40a2-81ac-5c5b0c8b0c8b", 0, "70085e9d-5428-4afb-85a5-c15792093366", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@gmail.com", true, "System", "Administrator", false, null, "TEST@GMAIL.COM", "TEST@GMAIL.COM", "AQAAAAIAAYagAAAAEIWOLNRZRfoXowG8riH+EF/I494FFCAsQhWSFwLfjwoRWH6Gd31wRk2uahOjHmzDNA==", null, false, "90cff9b1-46bc-44e2-9f12-17f5efd88a37", null, false, "test@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5f43a5f7-5d55-40a2-12ac-2c8b0c8b0c8b", "5f55a8f9-5d86-40a2-81ac-2c8b0c8b0c8b" },
                    { "5f43a8f9-5d86-40a2-81ac-2c8b0c8b0c8b", "5f55a8f9-5d86-40a2-81ac-5c5b0c8b0c8b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5f43a5f7-5d55-40a2-12ac-2c8b0c8b0c8b", "5f55a8f9-5d86-40a2-81ac-2c8b0c8b0c8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5f43a8f9-5d86-40a2-81ac-2c8b0c8b0c8b", "5f55a8f9-5d86-40a2-81ac-5c5b0c8b0c8b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f43a5f7-5d55-40a2-12ac-2c8b0c8b0c8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f43a8f9-5d86-40a2-81ac-2c8b0c8b0c8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f55a8f9-5d86-40a2-81ac-2c8b0c8b0c8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f55a8f9-5d86-40a2-81ac-5c5b0c8b0c8b");
        }
    }
}
