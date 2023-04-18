﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "77e77ee3-79e2-4faf-a7e4-eeaac736409f", "b346ef0d-31c5-459d-b29b-3bf4fde57c45", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd916318-a1e6-4a4e-97a3-2fddb8e7d0b3", "ba88d54a-0bbf-46c3-92d7-619d9f2a4628", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e7b370a9-ac96-4ac8-9b29-4a6aec9a2a52", "70788d9b-acfd-4e0c-ae75-90c02d5b52ea", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77e77ee3-79e2-4faf-a7e4-eeaac736409f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd916318-a1e6-4a4e-97a3-2fddb8e7d0b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7b370a9-ac96-4ac8-9b29-4a6aec9a2a52");
        }
    }
}