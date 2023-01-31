using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVCpetproject.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f55a8f9-5d86-40a2-81ac-2c8b0c8b0c8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63c204c2-0117-4c74-a508-df57301d8c6e", "AQAAAAIAAYagAAAAEB3465gviNouG20A5G8H6eHM6Yj2jTuTzz8HNhoa4LQjd3XZ9Fqjq+lWeADSk28Xow==", "c44d699d-040b-426e-8799-6009c7e21762" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f55a8f9-5d86-40a2-81ac-5c5b0c8b0c8b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "400b8073-9c19-4597-a426-c028c79fb829", "AQAAAAIAAYagAAAAEC9jEji3HgQtqOEySoo3GVUnqf+/k6dI5+NoYUbEcAlgYaiogONjl9ArNsrjqHcN9g==", "a4c4e4f5-4f29-4301-ab65-0b34adacd01e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
