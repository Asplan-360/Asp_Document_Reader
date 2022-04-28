using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asp_Document_Reader.Server.Migrations
{
    public partial class Initialschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b41d1c9-d288-413b-951d-c47ed5279e0c", "0b16763b-9521-40ac-b784-f142035dae10", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "644a2358-f06f-4478-81b2-41dfac072399", "b3d4bd9b-208f-4d5f-bc13-3acc7ce90113", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b41d1c9-d288-413b-951d-c47ed5279e0c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "644a2358-f06f-4478-81b2-41dfac072399");
        }
    }
}
