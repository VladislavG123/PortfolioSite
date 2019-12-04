using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolio.Migrations
{
    public partial class FixId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Description", "ImageURL", "LastName", "Name" },
                values: new object[] { new Guid("b6ea33c5-4e14-40c5-83a5-078ced35cde1"), "I am Vlad", null, "Gorokhov", "Vladislav" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6ea33c5-4e14-40c5-83a5-078ced35cde1"));
        }
    }
}
