using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListingNew.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d1987852-93a4-45e6-96d2-e5d2c46d7436", "1da3171d-cffa-4c59-8e22-7b5392f6bd0f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c475f029-7279-44d1-a060-17fe07750abb", "3845de4b-b383-42a5-9b60-40e9a4dd25b9", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c475f029-7279-44d1-a060-17fe07750abb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1987852-93a4-45e6-96d2-e5d2c46d7436");
        }
    }
}
