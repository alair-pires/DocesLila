using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DocesLila.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ExpireDate", "Price", "Quantity", "RegistrationDate", "Title" },
                values: new object[,]
                {
                    { 1, "gostoso", new DateTime(2023, 8, 2, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(2730), 10.0, 300, new DateTime(2023, 7, 30, 23, 47, 1, 646, DateTimeKind.Local).AddTicks(6424), "Casadinho" },
                    { 2, "muito bom", new DateTime(2023, 8, 3, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3022), 8.0, 200, new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3019), "Bala de coco" },
                    { 3, "Delicia", new DateTime(2023, 8, 9, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3028), 5.0, 120, new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3027), "Rosquinha" },
                    { 4, "Doce", new DateTime(2023, 8, 14, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3030), 4.0, 500, new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3030), "Suspiro" },
                    { 5, "Saboroso", new DateTime(2023, 8, 1, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3032), 12.0, 82, new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3032), "Biscoito de Nozes" },
                    { 6, "Chocolate", new DateTime(2023, 7, 31, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3034), 20.0, 40, new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3034), "Alfajor" },
                    { 7, "Macio", new DateTime(2023, 8, 6, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3036), 6.0, 234, new DateTime(2023, 7, 30, 23, 47, 1, 647, DateTimeKind.Local).AddTicks(3036), "Goiabinha" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
