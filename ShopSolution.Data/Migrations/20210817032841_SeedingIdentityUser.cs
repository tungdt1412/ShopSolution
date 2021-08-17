using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopSolution.Data.Migrations
{
    public partial class SeedingIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e1bc4150-7555-42f2-8e6f-e6670c01b485");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Dob", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "2aa5e3e8-b3a6-4001-b7bd-c286344aa2c1", new DateTime(2000, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "tungdt1412@gmail.com", "Tung", "Duong", "tungdt1412@gmail.com", "AQAAAAEAACcQAAAAEJJQqP9iAXJzUgbC98N/aBhP5wLSheYCPruuGq+bbU/5sU12Ag3RIt4GyXVzoOHJTA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 17, 10, 28, 40, 472, DateTimeKind.Local).AddTicks(496));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "3b68e242-7014-463f-a552-ad221521132d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Dob", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "5ea8dd7e-6523-4c34-ab9a-df9cc7794566", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", "Toan", "Bach", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAEAq5P2Oh0MsMDSMR+nqBqWZzBVaqEd0IwaXtocJZyBJ3/ylo1yAy2lnpu/l26iDWSw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 17, 10, 22, 37, 784, DateTimeKind.Local).AddTicks(8423));
        }
    }
}
