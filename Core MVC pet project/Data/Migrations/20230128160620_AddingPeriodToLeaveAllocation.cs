using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVCpetproject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToLeaveAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f55a8f9-5d86-40a2-81ac-2c8b0c8b0c8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78fbb039-48be-40bd-b7c8-e5dd5e6475b4", "AQAAAAIAAYagAAAAEIKs5fJshdsRPcc72gQmfwXO6wqELPO1L2rlbSE1r6mdr2lv8tm3jdLdFiE0AE/xmQ==", "68c18fcb-7ac1-4f3e-9a82-8168cc364ac6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f55a8f9-5d86-40a2-81ac-5c5b0c8b0c8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fafe1bd3-9500-4d6d-80dc-0e395732a832", "AQAAAAIAAYagAAAAEP+niFeyvOvHyHY0ZJdsc7tGWTBKJlxOHJBdXEtzhUhmPKNkXepHpLkab9tqWLK0mw==", "e22bca22-72ff-4ee5-92af-f8176b7d5191" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f55a8f9-5d86-40a2-81ac-2c8b0c8b0c8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1597f3a-5c84-46d6-86d8-c5929c85fa21", "AQAAAAIAAYagAAAAEEzEBbeInQ13zBuk4oEwQdiR84L/eHTWuEt1pOiiAlCvgwlg1y8Q3DhyhRXT3SogCw==", "3c23d865-feac-4226-b93f-c2c11868d633" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f55a8f9-5d86-40a2-81ac-5c5b0c8b0c8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70085e9d-5428-4afb-85a5-c15792093366", "AQAAAAIAAYagAAAAEIWOLNRZRfoXowG8riH+EF/I494FFCAsQhWSFwLfjwoRWH6Gd31wRk2uahOjHmzDNA==", "90cff9b1-46bc-44e2-9f12-17f5efd88a37" });
        }
    }
}
