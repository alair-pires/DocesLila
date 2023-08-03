using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DocesLila.Migrations
{
    public partial class ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 5, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1454), new DateTime(2023, 8, 2, 22, 55, 36, 7, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1752), new DateTime(2023, 8, 2, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 12, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1759), new DateTime(2023, 8, 2, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 17, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1761), new DateTime(2023, 8, 2, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 4, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1763), new DateTime(2023, 8, 2, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 3, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 8, 2, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 9, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1768), new DateTime(2023, 8, 2, 22, 55, 36, 8, DateTimeKind.Local).AddTicks(1767) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 2, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 7, 30, 23, 47, 1, 646, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 3, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 9, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3028), new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 14, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 1, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3032), new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 7, 31, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3034), new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExpireDate", "RegistrationDate" },
                values: new object[] { new DateTime(2023, 8, 6, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3036), new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3036) });
        }
    }
}
