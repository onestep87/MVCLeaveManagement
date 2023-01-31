using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVCpetproject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f55a8f9-5d86-40a2-81ac-2c8b0c8b0c8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "943b0d1d-1f52-4d5c-accd-cdc852cc63ee", "AQAAAAIAAYagAAAAEKbgyCdR8xzq6Zox91rySFeClhvZwDuxF7BlcLadZcA5mr0mXC1/OYiYP+gmFGZRnA==", "d4c1d56f-20a4-4c1b-85e6-f88915e6819d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f55a8f9-5d86-40a2-81ac-5c5b0c8b0c8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aeaabd02-8d41-4f3d-8d88-cb8188e28c86", "AQAAAAIAAYagAAAAEPaXOJ9CMyMOKj/jFXRvhdmkbpd0oVbV+WZrJuTgTYTmlb8akqARo4V3LWYPUR0gdQ==", "c2ead7ae-dbf1-4ef5-9cf8-33cac00552ba" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
